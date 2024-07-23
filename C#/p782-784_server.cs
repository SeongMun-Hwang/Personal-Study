using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

namespace EchoServer
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p782
            if(args.Length < 1)
            {
                WriteLine("Usage : {0} <Bind IP>",Process.GetCurrentProcess().ProcessName);
                return;
            }
            string bindIp=args[0];
            const int bindPort = 5425;

            //p783
            TcpListener server = null;
            try
            {
                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);

                server = new TcpListener(localAddress);
                server.Start();

                WriteLine("Echo Server start...");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    WriteLine("Client Access : {0} ", ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

                    NetworkStream stream = client.GetStream();

                    int length;
                    string data = null;
                    byte[] bytes = new byte[256];

                    while((length = stream.Read(bytes, 0, bytes.Length)) != 0){
                        data = Encoding.Default.GetString(bytes, 0, length);
                        WriteLine(String.Format("Receive : {0}", data));

                        byte[] msg = Encoding.Default.GetBytes(data);

                        stream.Write(msg, 0, msg.Length);
                        WriteLine(String.Format("Transmit : {0}", data));
                    }

                    stream.Close();
                    client.Close();
                }
            }
            //p784
            catch(SocketException e)
            {
                WriteLine(e);
            }
            finally
            {
                server.Stop();
            }
            WriteLine("Close Server...");
        }
    }
}