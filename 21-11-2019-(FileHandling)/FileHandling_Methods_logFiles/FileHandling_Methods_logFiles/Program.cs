using System;
using System.IO;

namespace FileHandling_Methods_logFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"E:\gitFolder\ismail\21-11-2019-(FileHandling)\log.txt";
            FileInfo fi = new FileInfo(filepath);
            try
            {
                if (!fi.Exists)
                {
                    using (FileStream fs = File.Create(filepath)) { }
                }
                using (StreamWriter sw = File.AppendText("filepath"))
                {
                    Log("test1", sw);
                    Log("test2", sw);
                }
                using (StreamReader sr = File.OpenText(filepath))
                {
                    ReadLogText(sr);
                }
                Console.WriteLine("Done");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception is occured :"+ ex.Message);
            }
        }
        private static void Log(string str, StreamWriter sw)
        {
            sw.Write("\r\n LogEntry:");
            sw.WriteLine($"{DateTime.Now.ToLongTimeString()}{DateTime.Now.ToLongDateString()}");
            sw.Write("  :");
            sw.WriteLine($"  :logMessage");
            sw.WriteLine("=============");
        }
        private static void ReadLogText(StreamReader sr)
        {
            string line;
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
