using System;
using System.IO;
namespace FileHandling_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirpath = @"E:\gitFolder\ismail\21-11-2019-(FileHandling)\Directory";
            try
            {
                //check availability of directory
                if(Directory.Exists(dirpath))
                {
                    Console.WriteLine("Directory is already exists");
                    return;
                }
                // create directory
                DirectoryInfo di = Directory.CreateDirectory(dirpath);
                Console.WriteLine("Directory was created successfully:{0}",Directory.GetCreationTime(di.ToString()));

                //create subdirectory
                DirectoryInfo dis = di.CreateSubdirectory("SubDir");
                Console.WriteLine("SubDirectory was created successfully:{0}", Directory.GetCreationTime(di.ToString()));

                //copying directories
                
                //deleting directory
                di.Delete();
                Console.WriteLine("Directory was deleted successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("The process failed: {0}",ex.Message);
            }
            Console.WriteLine("Done");
        }
    }
}
