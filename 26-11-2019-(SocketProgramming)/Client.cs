using System;
using System.Collections.Generic;
using System.Linq;
using Text;
using System.Net;
using System.Net.Sockets;
namespace Client
{
    class Programm
    {
        static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IpEndPoint(IPAddress.Parse("127.0.0.1"),1234);
            try
            {
                sck.Connect(localEndPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception raised"+ex);
            }
            sck.Bind(new IPEndPoint(0, 1234));
            sck.Listen(100);
            socket accept = sck.Accept();
            Buffer = new byte[accepted.SendBufferSize];
    }
}