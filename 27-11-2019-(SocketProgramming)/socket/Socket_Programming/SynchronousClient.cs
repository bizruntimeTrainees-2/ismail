using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Socket_Programming
{
 class Program
 { 
   public class Cilent_Sychronous_Socket
   {
          public static void StartClient()
          {
              byte[] bytes = new byte[1024];

              try

              {
                  var Hostname = Dns.GetHostName();
                  IPHostEntry ipHostInfo = Dns.GetHostEntry(Hostname);
                  Console.WriteLine($"Host: {Hostname}");

                  IPAddress ipAddress = ipHostInfo.AddressList[1];
                  IPEndPoint remoteep= new IPEndPoint(ipAddress, 45693);

                  Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                  try
                  {
                      sender.Connect(remoteep);
                    Console.WriteLine("Socket Connected", sender.RemoteEndPoint.ToString());
                    ;

                      byte[] msg = Encoding.ASCII.GetBytes("This is just a test");
                      int bytesent = sender.Send(msg);

                      int byteReceive = sender.Receive(bytes);
                      Console.WriteLine($"Echoed Test { Encoding.ASCII.GetString(bytes, 0, byteReceive)}");

                      sender.Shutdown(SocketShutdown.Both);
                      sender.Close();
                  }

                  catch (ArgumentNullException an)
                  {
                      Console.WriteLine(an.Message);
                      throw;
                  }
                  catch (SocketException se)
                  {
                      Console.WriteLine( se.Message);

                  }
                  catch (Exception e)
                  {
                      Console.WriteLine( e.Message);

                  }
              }
              catch (Exception e)
              {
                  Console.WriteLine(e.Message);
              }
          }
      }

              static void Main(string[] args)
              {
              Console.WriteLine("Pree any key to continuee..");
              Console.ReadKey();
              Cilent_Sychronous_Socket.StartClient();
              Console.ReadLine();

             }

      }
}
      
   /* class Client
    {
        static Socket sck;
        static string ip;
        static int port;

        static void GetData()
        {
            Console.WriteLine("Client");
            Console.Write("Enter IP Address : ");
            ip = Console.ReadLine();
            Console.Write("Enter Port Number : ");
            port = Convert.ToInt16(Console.ReadLine());

        }

        static void Connection()
        {

            Console.WriteLine("Connecting.....");
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ed = new IPEndPoint(IPAddress.Parse(ip), port);

            try
            {
                sck.Connect(ed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Operation()
        {
            Byte[] bt = new Byte[255];
            int l = sck.Receive(bt, 0, bt.Length, 0);
            Array.Resize(ref bt, l);
            Console.WriteLine(Encoding.Default.GetString(bt));

            String str = "", str2 = "";
            while (!str.Equals("stop"))
            {
                Console.Write("Enter Text : ");
                str = Console.ReadLine();
                Byte[] data1 = Encoding.ASCII.GetBytes(str);
                sck.Send(data1);
                Console.WriteLine("Send Successful");

                int r = sck.Receive(bt, 0, bt.Length, 0);
                Array.Resize(ref bt, r);
                str2 = Encoding.Default.GetString(bt);
                Console.WriteLine("Server says: " + str2);
            }
        }
        static void Main(string[] args)
        {
            GetData();
            Connection();
            Operation();
            Console.WriteLine("Press any key");
            Console.Read();
            sck.Close();
        }
    }

} */
