using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace SocketServer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(0, 2200));
            sck.Listen(0);
            try
            {
                Socket acc = sck.Accept();
                byte[] buffer = Encoding.Default.GetBytes("Hello Client");
                acc.Send(buffer, 0, buffer.Length, 0);
                buffer = new byte[255];
                int rec = acc.Receive(buffer, 0, buffer.Length, 0);

                Array.Resize(ref buffer, rec);

                Console.WriteLine("Received! {0}", Encoding.Default.GetString(buffer));
                Console.Read();
                sck.Close();
                acc.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("server unable to Connect! :"+ex.Message);
            }
           
           
        }
    }
}
