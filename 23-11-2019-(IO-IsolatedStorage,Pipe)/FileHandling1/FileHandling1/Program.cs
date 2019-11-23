using System;
using System.IO;
using System.Threading.Tasks;
namespace FileHandling1
{
    class Program
    {
       public static void Main(string[] args)
        {
            MethodAsync().Wait();
            Console.WriteLine("done");
        }
       public static async Task  MethodAsync()
        {
            string sourceFile = @"E:\gitFolder\ismail\20-11-2019-(FileHandling)\temp.txt";
            string destination = @"E:\gitFolder\ismail\22-11-2019-(Filehandling)";
            using (StreamReader sr = File.OpenText(sourceFile))
            {
                using (StreamWriter sw = File.CreateText(destination +"copiedFile.txt"))
                {
                    await CopyFileAsync(sr, sw);
                }
            }
        }
        public static async  Task CopyFileAsync(StreamReader source, StreamWriter destination)
        {
            char[] ch = new char[0x1000];
            int numRead;
            while ((numRead = await source.ReadAsync(ch, 0, ch.Length)) != 0)
            {
                await destination.WriteAsync(ch, 0, numRead);
            }
        }
                  
    }
}
