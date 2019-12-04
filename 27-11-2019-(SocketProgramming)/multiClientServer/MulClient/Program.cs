using System;
using System.Net.Sockets;
using System.Threading;
using System.IO;
namespace MulClient
{
    public class MultiClient
    {
        static public void Main(string[] Args)
        {
            TcpClient socketForServer;
            try
            {
                socketForServer = new TcpClient("localHost", 10);
            }
            catch
            {
                Console.WriteLine("Failed to connect to server");
                return;
            }

            NetworkStream networkStream = socketForServer.GetStream();
           StreamReader streamReader =new StreamReader(networkStream);
            StreamWriter streamWriter = new StreamWriter(networkStream);
            Console.WriteLine("This is client program who is connected to localhost on port No:10");
            try
            {              
              {
                  Console.WriteLine("type:");
                    string str = Console.ReadLine();
                    while (str != "exit")
                    {
                        streamWriter.WriteLine(str);
                        streamWriter.Flush();
                        Console.WriteLine("type:");
                        str = Console.ReadLine();
                    }
                    if (str == "exit")
                    {
                        streamWriter.WriteLine(str);
                        streamWriter.Flush();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception reading from Server");
            }
            
            networkStream.Close();
            Console.WriteLine("Press any key to exit from client program");
            Console.ReadKey();
        }

        private static string GetData()
        {
            return "ack";
        }
    }
}