using System.Net;
using System.Net.Sockets;
using System.Text;

namespace server
{
    class Program
    {
        static TcpListener listener;
        static TcpClient client;

        public static void Main(string[] args)
        {
            //1. TCP Lytter
            IPAddress address = IPAddress.Parse("0.0.0.0");
            listener = new TcpListener(address, 1337);
            listener.Start();
            Console.WriteLine($"Lytter op {address}:1337");

            //2. Afvent forbindelse
            client = listener.AcceptTcpClient();
            Console.WriteLine("Ny forbindelse");

            //3. Udskriv modtagning i console
            byte[] buffer = new byte[1024];

            NetworkStream stream = client.GetStream();
            int length = stream.Read(buffer, 0, buffer.Length);

            string request = Encoding.UTF8.GetString(buffer, 0, length);

            Console.WriteLine(request);

            Console.ReadKey();
        }
    }
}


