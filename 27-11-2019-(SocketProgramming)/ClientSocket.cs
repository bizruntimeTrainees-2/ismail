using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ClientSocket
{
    class Programm
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),2222);
            try
            {
                sck.Connect(endPoint);
               Console.Write("Enter message:");
               string msg = Console.ReadLine();
               byte[] msgBuffer = Encoding.ASCII.GetBytes(msg);
               sck.Send(msgBuffer, 0, msgBuffer.Length,0);
               byte[] buffer = new byte[255];
               int rec = sck.Receive(buffer,0,buffer.Length,0);
               Array.Resize(ref buffer, rec);
               Console.WriteLine("Received:"+ Encoding.ASCII.GetString(buffer));
               Console.Read();
               sck.Close();
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Unable to connect server!");
            }
        }
    }
}
