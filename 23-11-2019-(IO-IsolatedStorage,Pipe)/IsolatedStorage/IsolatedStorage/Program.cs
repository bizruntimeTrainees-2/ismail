using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace IsolatedStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            //get new  isolated store for user, domain, assembly
            // then put the store in an isolatedStorage file
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User |
                                                                        IsolatedStorageScope.Domain | 
                                                                        IsolatedStorageScope.Assembly, null, null);
            //create directories
            Console.WriteLine("Creating directories");
            isoStore.CreateDirectory("E:\\gitFolder\\ismail\\22-11-2019-(Filehandling)\\FirstDirectory");
            isoStore.CreateDirectory("E:\\gitFolder\\ismail\\22-11-2019-(Filehandling)\\FirstDirectory\\SecondDirectory");
            Console.WriteLine("Created directories");

            // create files
            Console.WriteLine("creating Files");
            IsolatedStorageFileStream isoFile1 = new IsolatedStorageFileStream("E:\\gitFolder\\ismail\\22-11-2019-(Filehandling)\\FirstDirectory\\temp1.txt", FileMode.Create, isoStore);
            isoFile1.Close();
            IsolatedStorageFileStream isoFile2 = new IsolatedStorageFileStream("E:\\gitFolder\\ismail\\22-11-2019-(Filehandling)\\FirstDirectory\\SecondDirectory\\temp2.txt", FileMode.Create, isoStore);
            isoFile2.Close();
            Console.WriteLine("created Files");

            //deleting file
            isoStore.DeleteFile("E:\\gitFolder\\ismail\\22-11-2019-(Filehandling)\\FirstDirectory\\temp1.txt");
            Console.WriteLine("Deleted File");

            Console.WriteLine("Done");
        }
    }
}
