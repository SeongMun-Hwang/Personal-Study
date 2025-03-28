using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Console;

namespace Program
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p784
            if (args.Length < 4)
            {
                Console.WriteLine("Usage : {0} <Bind IP> <Bind Port> <Server IP> <Message>",
                    Process.GetCurrentProcess().ProcessName);
                return;
            }
            string bindIp = args[0];
            //p785
            int bindPort=Convert.ToInt32(args[1]);
            string serverIp=args[2];
            const int serverPort = 5425;
            string message =args[3];

            try
            {
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                WriteLine("Client : {0}, Server : {1}", clientAddress.ToString(), serverAddress.ToString());

                TcpClient client = new TcpClient(clientAddress);

                client.Connect(serverAddress);

                byte[] data = System.Text.Encoding.Default.GetBytes(message);

                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                WriteLine("Transmit : {0}", message);

                data = new byte[256];

                string responseData = "";

                int bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.Default.GetString(data, 0, bytes);
                WriteLine("Recieve : {0}", responseData);

                stream.Close();
                client.Close();
            }
            catch(SocketException e)
            {
                //p786
                WriteLine(e);
            }
            WriteLine("Close Client...");
        }
    }
}