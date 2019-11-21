using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace FileHandling_Methods
{
    class Program
    { 
        static async Task  Main()
        {
            string filepath = @"E:\gitFolder\ismail\21-11-2019-(FileHandling)\temp.txt";
            try
            {
                using (FileStream fs = File.Create(filepath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is adding content or overriding content");
                    fs.Write(info, 0, info.Length);
                }
               
                string path = @"E:\gitFolder\ismail\21-11-2019-(FileHandling)";
               
                using (StreamWriter sw = new StreamWriter(Path.Combine(path, "temp.txt")))
                {
                    await sw.WriteAsync("This is async sentence");
                }
                Console.WriteLine("Enter Strings:");
                string text =Console.ReadLine()+",";
                Console.WriteLine("Enter array of Strings:");
                string[] lines = {Console.ReadLine() };
                File.WriteAllText(Path.Combine(path, "temp.txt"), text);
                File.AppendAllLines(Path.Combine(path, "temp.txt"), lines);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception raised: "+ex.Message);
            }
            Console.WriteLine("Done");
        }
    }
}
