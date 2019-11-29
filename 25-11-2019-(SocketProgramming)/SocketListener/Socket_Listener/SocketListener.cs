using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace Socket_Listener
{
    public class SocketListener
    {
        public static int Main(string[] args)
        {
            StartServer();
            return 0;
        }
        public static void StartServer()
        {
            // Get Host IP Address that is used to establish a connection  
            // If a host has multiple addresses, you will get a list of addresses  

            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 1100);

            try
            {
                // Create a Socket that will use Tcp protocol      
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // A Socket must be associated with an endpoint using the Bind method  
                listener.Bind(localEndPoint);
                // Specify how many requests a Socket can listen before it gives Server busy response.  
                // it will listen 100 requests at a time  
                listener.Listen(100);

                Console.WriteLine("Waiting for a connection...");
                Socket sender = listener.Accept();

                string data = null;
                byte[] bytes = null;

                while (true)
                {
                    bytes = new byte[1024];
                    int bytesRec = sender.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("test") > -1)
                    {
                        break;
                    }
                }
                Console.WriteLine("Text received:{0}", data);
                byte[] msg = Encoding.ASCII.GetBytes(data);
                sender.Send(msg);
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in server:" + e.Message);
            }
            Console.WriteLine("\n press any key to continue...");
            Console.ReadKey();
        }
    }
}
