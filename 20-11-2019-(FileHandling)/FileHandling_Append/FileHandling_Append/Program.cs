using System;
using System.IO;
using System.Linq;
namespace FileHandling_Append
{
    class Program
    {
        static string dataPath = @"E:\gitFolder\ismail\20-11-2019-(FileHandling)"; 
        static void Main(string[] args)
        {
            CreatSimpleFile();

            var aprilWeekends = from line in File.ReadLines(dataPath)
                               where line.StartsWith("Saturday") ||
                                     line.StartsWith("Sunday") &
                                     line.Contains("April")
                               select line;
            File.WriteAllLines(@"E:\gitFolder\ismail\20-11-2019-(FileHandling)", aprilWeekends);

            var mayMondays = from line in File.ReadLines(dataPath)
                             where line.StartsWith("Monday") &
                                   line.Contains("May")
                             select line;
            File.AppendAllLines(@"E:\gitFolder\ismail\20-11-2019-(FileHandling)", mayMondays);

           Console.WriteLine("Done");
        }
        static void CreatSimpleFile()
        {
            DateTime timeStamp = new DateTime(2020,1,1);
            try
            {
                using (StreamWriter sw = File.CreateText(dataPath))
                {
                    for (int i = 0; i < 500; i++)
                    {
                        DateTime ds1 = timeStamp.AddYears(i);
                        DateTime ds2 = ds1.AddMonths(i);
                        DateTime ds3 = ds2.AddDays(i);
                        sw.WriteLine(ds3.ToLongDateString());
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("exception handled "+ ex.Message);
            }
                   }
    }
}
