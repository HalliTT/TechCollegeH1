using System.Net;
using System.Net.Sockets;
using System.Text;

namespace server
{
    class Program
    {
        static TcpListener? listener;
        static TcpClient? client;

        public static void Main(string[] args)
        {
            //1. TCP Listener
            IPAddress address = IPAddress.Parse("0.0.0.0");
            listener = new TcpListener(address, 1337);
            listener.Start();
            Console.WriteLine($"Lytter op {address}:1337");

            //2. wait for connection
            while (true)
            {
                client = listener.AcceptTcpClient();
                Console.WriteLine("Ny forbindelse");

                //3. Print out recived data
                byte[] buffer = new byte[1024];

                NetworkStream stream = client.GetStream();
                int length = stream.Read(buffer, 0, buffer.Length);

                //Header client(browser) sends
                string request = Encoding.UTF8.GetString(buffer, 0, length);
                Console.WriteLine(request);

                //Split all before route
                string[] removeGet = request.Split("GET ");
                string stringAfterGet = removeGet[1];

                //Split all after route
                string[] removeHTTP = stringAfterGet.Split(" HTTP/");
                string docs = removeHTTP[0];



                string type = "";
                if (docs.Length > 2)
                {
                    string[] removeDot = docs.Split(".");
                    type = removeDot[1];
                    if (type == "css")
                    {
                        type = "text/css";
                    }
                    if (type == "png")
                    {
                        type = "image/png";
                    }
                }
                else
                {
                    type = "text/html";
                }

                Console.WriteLine(type);


                //If route exist else show 404
                if (File.Exists($"htdocs{docs}"))
                {
                    //Send Respond to Client(Browser)
                    SendResponse(File.ReadAllText($"htdocs/{docs}"), stream, "200", type);
                }
                else if (docs == "/")
                {
                    //Send Respond to Client(Browser)
                    SendResponse(File.ReadAllText($"htdocs/index.html"), stream, "200", type);
                }
                else if (docs == "/img/dog.png")
                {
                    //Send Respond to Client(Browser)
                    var bytes = File.ReadAllBytes($"img/dog.png");
                    byte[] buffers = Encoding.UTF8.GetBytes($"HTTP/1.1 200 OK\nContentt-Type:image/png\n\n");
                    byte[] ultimateBuffer = new byte[bytes.Length + buffers.Length];

                    buffers.CopyTo(ultimateBuffer, 0);
                    bytes.CopyTo(ultimateBuffer, buffers.Length);

                }
                else
                {
                    //Send Respond to Client(Browser)
                    SendResponse(File.ReadAllText($"htdocs/404.html"), stream, "404", type);
                }
            }
        }

        //4. Send Ersponse
        public static void SendResponse(string html, NetworkStream stream, string code, string type)
        {
            string response = @$"HTTP/1.1 {code} OK
Content-Type: {type}; charset=utf-8

            {html}";

            byte[] responseBytes = new byte[0];


            if (type == "text/html" || type == "text/css")
            {
                //Convert text to bytes
                responseBytes = Encoding.UTF8.GetBytes(response);
            }
            else if (type == "image/png")
            {
                responseBytes = Encoding.ASCII.GetBytes(response.ToString());
            }

            stream.Write(responseBytes, 0, response.Length);



            //Write bytes ti client (browser)
            stream.Close();
            stream.Close();
        }
    }
}


