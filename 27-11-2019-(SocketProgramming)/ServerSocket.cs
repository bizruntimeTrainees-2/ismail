using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ServerSocket
{
    class Programm
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind( new IPEndPoint(0,2222));
            sck.Listen(10);
            try
            {
                  Socket acc = sck.Accept();
               byte[] buffer = Encoding.ASCII.GetBytes("HelloClient");
               acc.Send(buffer, 0, buffer.Length,0);
                buffer = new byte[255];
               int rec = sck.Receive(buffer,0,buffer.Length,0);

               Array.Resize(ref buffer, rec);
               Console.WriteLine("Received:"+ Encoding.ASCII.GetString(buffer));
               Console.Read();
               sck.Close();
               acc.Close();
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Unable to connect !");
            }
        }
    }
}
