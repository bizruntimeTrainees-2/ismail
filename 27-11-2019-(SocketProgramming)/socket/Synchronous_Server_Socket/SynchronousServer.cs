using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Synchronous_Server_Socket

{
    class Program
    {
        public class SyncServerSocket
        {
            public static string data;
            public static void StartListener()
            {
                byte[] bytes = new byte[1024];
                
                
                
                IPHostEntry iphost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = iphost.AddressList[1];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 45693);

                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(1);
                    while (true)
                    {
                        Console.WriteLine("Waiting for a connection");
                        Socket handler = listener.Accept();
                        while (true)
                        {
                            int byterec = handler.Receive(bytes);
                            data += Encoding.ASCII.GetString(bytes, 0, byterec);
                            if (data.IndexOf("<EOF>" ) > -1)
                                break;
                        }
                        Console.WriteLine("Text Received:{0}",data );
                        byte[] msg = Encoding.ASCII.GetBytes(data);
                        handler.Send(msg);

                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Press any key to Exit");
                Console.ReadLine();

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to continue....");
            Console.ReadLine();
            SyncServerSocket.StartListener();
            Console.ReadLine();
        }

    }
}
 
 
  /*  class Server
    {
        static Byte[] Buffer { get; set; }
        static Socket sck;
        static Socket Accepted;
        static void Connection()
        {
            Console.WriteLine("Server");
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(0, 1234));
            sck.Listen(1);
            Console.WriteLine("The server is running at port 1234...");
            Console.WriteLine("Waiting for a connection.....");

            Accepted = sck.Accept();
            Console.WriteLine("Connection accepted from " + Accepted.RemoteEndPoint);

            Byte[] con = Encoding.Default.GetBytes("Connected Successfull");
            Accepted.Send(con, 0, con.Length, 0);
        }

        static void Operation()
        {
            String str = "", str2 = "";
            while (!str.Equals("stop"))
            {
                Buffer = new Byte[Accepted.SendBufferSize];
                int bytesread = Accepted.Receive(Buffer);
                Byte[] formattd = new Byte[bytesread];
                for (int i = 0; i < bytesread; i++)
                {
                    formattd[i] = Buffer[i];
                }
                str = Encoding.ASCII.GetString(formattd);
                Console.WriteLine("client says: " + str);
                Console.Write("Enter Text : ");
                str2 = Console.ReadLine();
                Byte[] buf = Encoding.Default.GetBytes(str2);
                Accepted.Send(buf, 0, buf.Length, 0);
                Console.WriteLine("Send Successfull");

            }
        }
        static void Main(string[] args)
        {
            Connection();
            Operation();
            Console.Read();
            sck.Close();
            Accepted.Close();
        }


    }


} */
