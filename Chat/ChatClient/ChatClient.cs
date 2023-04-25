using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatClient
{
    class ChatClient
    {
        const int PORT = 31337;
        TcpClient connection;

        public void Connect(string ip, int port)
        {
            connection = new TcpClient();
            connection.Connect(ip, port);
            Console.WriteLine($"Client forbundet til server {ip}");

            //Lytter til broadcasting fra serveren
            Thread thread = new Thread(Listen);
            thread.Start();
        }

        public void Listen()
        {
            NetworkStream stream = connection.GetStream();
            byte[] buffer = new byte[4096];
            while (connection.Connected)
            {
                int read = stream.Read(buffer, 0, buffer.Length);
                string messageFromServer = Encoding.UTF8.GetString(buffer, 0, read);
                Console.WriteLine(messageFromServer);
                buffer = new byte[4096];
            }
        }

        public void SendMessage(string message)
        {
            if (connection.Connected) 
            { 
                NetworkStream stream = connection.GetStream();
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                //stream.Close();
            }
        }

        public void Run()
        {
            Connect("127.0.0.1", PORT);
            while (true)
            {
                string send = Console.ReadLine();
                SendMessage(send);
            }
        }

        //public void Recive()
        //{

        //}

    }
}
