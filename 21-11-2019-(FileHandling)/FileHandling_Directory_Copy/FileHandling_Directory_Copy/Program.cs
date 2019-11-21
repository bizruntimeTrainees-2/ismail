using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileHandling_Directory_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            string docpath = @"E:\gitFolder\ismail\21-11-2019-(FileHandling)";
            try
            {
                //Enumerating the directory files
                List<string> dirlist = new List<string>(Directory.EnumerateDirectories(docpath));
                foreach(var dir in dirlist)
                {
                    Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar)+1)}");
                }
                Console.WriteLine($"{dirlist.Count} directories are found");

                //reading files with specified extension
                var files = from file in Directory.EnumerateFiles(docpath, "*.txt", SearchOption.AllDirectories)
                            from line in File.ReadLines(file)
                            where line.Contains("temp")
                            select new
                            {
                                File = file,
                                 Line = line
                            };
                foreach(var f in files)
                {
                    Console.WriteLine($"{f.File}\t{f.Line}");
                }

                //readaing the characters 
                string str = "Reading Charaters ";
                char[] ch = new char[str.Length];
                using (StreamReader sr = new StreamReader(str))
                {
                    sr.Read(ch, 0, 10);
                    Console.WriteLine(ch);

                    sr.Read(ch, 5,str.Length-10);
                    Console.WriteLine(ch);
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message} occured.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message} occured.");
            }
            catch (DriveNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message} occured.");
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine($"{ex.Message} occured.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"{ex.Message} occured.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"{ex.Message} occured.");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
