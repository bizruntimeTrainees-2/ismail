using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace SingleServer
{
    class Server
    {
        static byte[] Buffer { get; set; }
        static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //binds the ipendpoint address and port number
            sck.Bind(new IPEndPoint(0, 1234));

            //placing the socket in listening state
            sck.Listen(100);

            //create a socket for a newly created connection
            Socket accept = sck.Accept();

            //value that specifies the send buffer size
            Buffer = new byte[accept.SendBufferSize];
            //receive data from the bound socket into a received buffer
            int bytesRead = accept.Receive(Buffer);
            byte[] formatted = new byte[bytesRead];
            //reading received buffer data into formatted byte array
            for(int i= 0; i < bytesRead; i++)
            {
                formatted[i] = Buffer[i];
            }
            //getting an encoding for ascii char set and decodes all bytes into string form
            string strData = Encoding.ASCII.GetString(formatted);
            Console.WriteLine(strData + "\r\n");
            Console.ReadLine();
            //close the socket connection
            sck.Close();
        }
    }
}
