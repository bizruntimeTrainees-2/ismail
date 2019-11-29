using System;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace SocketClient
{
    class Program
    {
        static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            try
            {
                sck.Connect(localEndPoint);
            }
            catch
            {
                Console.WriteLine("Unable to Connect!\r\n");
            }
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);

            sck.Send(data);
            Console.WriteLine("data sent!\r\n");
            Console.Read();
            sck.Close();
        }
    }
}
