using System;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;
namespace Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if(args.Length > 0)
            {
                using (PipeStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, args[0]))
                {
                    Console.WriteLine("Client current Transmission mode:{0}", pipeClient.TransmissionMode);

                    using (StreamReader sr = new StreamReader(pipeClient))
                    {
                        string str;
                        //waiting for SYNC mesage from server
                        do
                        {
                            Console.WriteLine("Client is waiting for SYNC");
                            str = sr.ReadLine();
                        }
                        while (!str.StartsWith("SYNC"));
                        //show the server data on the console
                        while((str= sr.ReadLine()) != null)
                        {
                            Console.WriteLine("Client :{0}",str);
                        }
                    }
                }
            }
            Console.WriteLine("[Client] press enter to continue..");
            Console.ReadLine();
        }
    }
}
