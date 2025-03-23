using FUP;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

namespace FileReciver
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p807
            if (args.Length <1)
            {
                WriteLine("Usage : {0} <Directory>",
                    Process.GetCurrentProcess().ProcessName);
                return;
            }
            uint msgId = 0;

            string dir=args[0];
            if(Directory.Exists(dir)==false)
            {
                Directory.CreateDirectory(dir);
            }

            const int bindPort = 5425;
            TcpListener server = null;
            try
            {
                IPEndPoint localAddress = new IPEndPoint(0, bindPort);
                server = new TcpListener(localAddress);
                server.Start();

                WriteLine("Start File Upload Server...");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    WriteLine("Client connected : {0} ", ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

                    NetworkStream stream = client.GetStream();
                    Message reqMsg = MessageUtil.Receive(stream);

                    if (reqMsg.Header.MSGTYPE != CONSTANTS.REQ_FILE_SEND)
                    {
                        stream.Close();
                        client.Close();
                        continue;
                    }

                    BodyRequest reqBody = (BodyRequest)reqMsg.Body;

                    //p809
                    WriteLine("Got file upload request. Accept it? yes/no");
                    string answer = ReadLine();

                    Message rspMsg = new Message();
                    rspMsg.Body = new BodyResponse()
                    {
                        MSGID = reqMsg.Header.MSGID,
                        RESPONSE = CONSTANTS.ACCEPTED
                    };
                    rspMsg.Header = new Header()
                    {
                        MSGID = msgId++,
                        MSGTYPE = CONSTANTS.REP_FILE_SEND,
                        BODYLEN = (uint)rspMsg.Body.GetSize(),
                        FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                        LASTMSG=CONSTANTS.LASTMSG,
                        SEQ=0
                    };

                    if (answer != "yes")
                    {
                        rspMsg.Body = new BodyResponse()
                        {
                            MSGID = reqMsg.Header.MSGID,
                            RESPONSE = CONSTANTS.DENIED
                        };
                        MessageUtil.Send(stream, rspMsg);
                        stream.Close();
                        client.Close();

                        continue;
                    }
                    else MessageUtil.Send(stream, rspMsg);

                    WriteLine("Start file send...");

                    long fileSize = reqBody.FILESIZE;

                    //p810
                    string fileName = Encoding.Default.GetString(reqBody.FILENAME);
                    FileStream file = new FileStream(dir + "\\" + fileName, FileMode.Create);

                    uint? dataMsgId = null;
                    ushort prevSeq = 0;
                    while ((reqMsg = MessageUtil.Receive(stream)) != null)
                    {
                        Write("#");
                        if (reqMsg.Header.MSGTYPE != CONSTANTS.FILE_SEND_DATA)
                            break;

                        if (dataMsgId == null)
                            dataMsgId = reqMsg.Header.MSGID;
                        else
                        {
                            if (dataMsgId != reqMsg.Header.MSGID)
                                break;
                        }

                        if(prevSeq++ != reqMsg.Header.SEQ)
                        {
                            WriteLine("{0}, {1}", prevSeq, reqMsg.Header.SEQ);
                            break;
                        }

                        file.Write(reqMsg.Body.GetBytes(), 0, reqMsg.Body.GetSize());
                        if (reqMsg.Header.FRAGMENTED == CONSTANTS.NOT_FRAGMENTED)
                            break;
                        if (reqMsg.Header.LASTMSG == CONSTANTS.LASTMSG)
                            break;
                    }

                    long recvFileSize = file.Length;
                    file.Close();

                    WriteLine();
                    WriteLine("Received file size : {0} bytes", recvFileSize);

                    //p811
                    Message rstMsg = new Message();
                    rstMsg.Body = new BodyResult()
                    {
                        MSGID = reqMsg.Header.MSGID,
                        RESULT = CONSTANTS.SUCCESS,
                    };
                    rstMsg.Header = new Header()
                    {
                        MSGID = msgId++,
                        MSGTYPE = CONSTANTS.FILE_SEND_RES,
                        BODYLEN = (uint)rstMsg.Body.GetSize(),
                        FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                        LASTMSG = CONSTANTS.LASTMSG,
                        SEQ = 0,
                    };

                    if (fileSize == recvFileSize)
                        MessageUtil.Send(stream, rstMsg);
                    else
                    {
                        rstMsg.Body = new BodyResult()
                        {
                            MSGID = reqMsg.Header.MSGID,
                            RESULT = CONSTANTS.FAIL
                        };

                        MessageUtil.Send(stream, rstMsg);
                    }

                    WriteLine("Complete file send");
                    stream.Close();
                    client.Close();
                }
            }
            catch(SocketException e)
            {
                WriteLine(e);
            }
            finally
            {
                //p812
                server.Stop();
            }
            WriteLine("Close server");
        }
    }
}
