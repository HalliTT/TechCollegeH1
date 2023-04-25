using System.Net.Sockets;
using System.Text;

class Client
{
    public static void SendRequest(string path)
    {
        //https://dr.dk/path
        TcpClient client = new TcpClient();
        client.Connect("eb.dk", 80);
        string request_header = $@"GET {path} HTTP/2";
        NetworkStream stream = client.GetStream();
        byte[] bytes = Encoding.UTF8.GetBytes(request_header);
        stream.Write(bytes, 0, bytes.Length);

        byte[] buffer = new byte[1024];
        int length = stream.Read(buffer, 0, buffer.Length);

        string response = Encoding.UTF8.GetString(buffer, 0, length);
        Console.WriteLine(response);
        Console.ReadKey();
    }
}