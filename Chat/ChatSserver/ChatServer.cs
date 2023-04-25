using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    class ChatServer
    {
        //Port number
        const int PORT = 31337;

        //List be filled with clients
        List<TcpClient> clients = new();

        //
        public void Start() 
        {
            //Listenet and start port
            TcpListener listener = new TcpListener(IPAddress.Any, PORT);
            //start
            listener.Start();
            Console.WriteLine($"Server: lytter på port {PORT}");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NewClient(client);
            }
        }

        //Take recived and transform to string
        public string Recive(TcpClient client) 
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[4096];
            int read = stream.Read(buffer, 0, buffer.Length);

            //Make byte array to text
            string recive = Encoding.UTF8.GetString(buffer, 0, read);
            //stream.Close();

            Console.WriteLine($"Client wrote: {recive}");

            return recive;
        }

        //
        public void Broadcast(string message, TcpClient sender) 
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            foreach(TcpClient client in clients)
            {
                //fejl håndtering
                if (client.Connected && client.Equals(sender) == false)
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(bytes);
                }
            }
        }

        //
        public void NewClient(TcpClient client) 
        {
            Console.WriteLine($"New Client connect");
            clients.Add(client);
            //New Thread and start (as long as program lives)
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    string message = Recive(client);
                    Broadcast(message, client);
                }
            });
            thread.Start();
        }
    }
}
