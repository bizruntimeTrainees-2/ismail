using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDir = @"E:\C-sharp\FileHandling\CurrentFile";
            string backupDir = @"E:\C-sharp\FileHandling\BackupFile";
            try
            {
                string[] picList = Directory.GetFiles(sourceDir,"*.PNG");
                string[] textList = Directory.GetFiles(sourceDir, "*.txt");
                //copying picture files
                foreach(string f in picList)
                {
                    string fName = f.Substring(sourceDir.Length+1);
                    // Use the Path.Combine method to safely append the file name to the path.
                    // Will overwrite if the destination file already exists.
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                }
                foreach(string f in textList)
                {
                    string fName = f.Substring(sourceDir.Length + 1);
                    try
                    {
                        // Will not overwrite if the destination file already exists.
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }
                    //catch exception if file is already copied
                    catch(IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //deleting source files that were copied
                foreach(string f in textList)
                {
                    File.Delete(f);
                }
                foreach (string f in picList)
                {
                    File.Delete(f);
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Done");
        }
    }
}
