using System;
using System.IO;
using System.IO.Compression;


namespace FileHandling_ExtractingFile
{
  
    public class FileHandling
    {
        public static void Main(string[] args)
        {
            string zippath = @"C:\Users\ismai\Downloads\apache-maven-3.6.2-bin.zip";
            Console.WriteLine("Enter the path to where to extract");
            string extractpath = @"C:\Users\ismai\Downloads\temp";
            try
            {
                extractpath = Path.GetFullPath(zippath);
                //that the last character on the extraction path
                // is the directory separator char. 
                // Without this, a malicious zip file could try to traverse outside of the expected
                // extraction path.
                if (!extractpath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
                {
                    extractpath += Path.DirectorySeparatorChar;
                }
                using (ZipArchive archive = ZipFile.OpenRead(zippath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        // Gets the full path to ensure that relative segments are removed.
                        //better to go for Ordinal bcz Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                        // are case-insensitive.
                        if (entry.FullName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                        {
                            string destination = Path.GetFullPath(Path.Combine(extractpath, entry.FullName));
                            entry.ExtractToFile(destination);
                        }
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("raised Exception handled:"+ex.Message);
            }
        }
    }

}
