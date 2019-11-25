using System;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics;
namespace PipeServer
{
    class PipeServer
    {
        static void Main(string[] args)
        {
            //creating a process to the client.
            Process pipeClient = new Process();

            //defineing the name of the Client file to be execute with server
            pipeClient.StartInfo.FileName = "PipeClient.exe";

            //creating anonymous pipe server
            using(AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out,HandleInheritability.Inheritable))
            {
                //gets the connected client obj's handle as string
                pipeClient.StartInfo.Arguments = pipeServer.GetClientHandleAsString();

                //gets or sets a value indicating whether to use operating  system shell to start the process 
                pipeClient.StartInfo.UseShellExecute = false;
                //start the client process
                pipeClient.Start();
                
                //closes the pipeclientStream local handle
                pipeServer.DisposeLocalCopyOfClientHandle();
                try
                {
                    //read user input and send to the client process
                    using(StreamWriter sw  = new StreamWriter(pipeServer))
                    {
                        //flush its buffer to underlying stream  for every call of streamwriter
                        sw.AutoFlush = true;

                        // Send a 'input message' and wait for client to receive it.
                        sw.WriteLine("user input ");

                        //wait for other end of the pipe to read all send bytes
                        pipeServer.WaitForPipeDrain();

                        //send the console input to the client process
                        Console.WriteLine("[Server] enter the text:");
                        sw.WriteLine(Console.ReadLine());
                    }
                }
                catch(IOException ex)
                {
                    Console.WriteLine("[server] server error:"+ex.Message);
                }
            }
            //instructs the process to wait for the associate process to execute
            pipeClient.WaitForExit();

            //frees all the resources that associated with this 
            pipeClient.Close();

            Console.WriteLine("[SERVER] Client quit. Server terminating.");
        }
    }
}
