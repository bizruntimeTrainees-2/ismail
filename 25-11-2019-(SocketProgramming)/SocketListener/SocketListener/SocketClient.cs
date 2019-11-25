using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace SocketListener
{
   public class SocketClient
    {
        public static int Main(string[] args)
        {
            StartClient();
            return 0;       
        }
        public static void StartClient()
        {
            byte[] bytes = new byte[1024];

            try
            {
                //Get Connect to server
                // Get Host IP Address that is used to establish a connection  
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
                // If a host has multiple addresses, you will get a list of addresses 
                IPHostEntry iPHost = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = iPHost.AddressList[0];
                IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, 11000);

                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(iPEndPoint);
                    Console.WriteLine("socket conneted to {0}", sender.RemoteEndPoint.ToString());
                    //encode the data string into byte array
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test");
                    //send the data through socket
                    int bytesSent = sender.Send(msg);
                    //receive the response from the remote device
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoes test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    //release the socket
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch(ArgumentNullException aex)
                {
                    Console.WriteLine("Argumentnull exception:{0}", aex.Message);
                }
                catch (SocketException aex)
                {
                    Console.WriteLine("Socket exception:{0}", aex.Message);
                }
                catch (Exception aex)
                {
                    Console.WriteLine("unexpected exception:{0}", aex.Message);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception raised in server:"+ex.Message);
            }
        }
    }
}
