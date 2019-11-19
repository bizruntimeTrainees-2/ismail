using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;


namespace ConcurrentDictionary1
{
   public  class Program
    {
       static  ConcurrentDictionary<int, string> cd = new ConcurrentDictionary<int, string>();
      public  static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);
            t1.Start();
            t2.Start();         
        }
        static void M1()
        {
            for(int i = 0; i < 5; i++)
            {
               	Console.WriteLine( cd.TryAdd(i, "M1.added" + i)+" M1");
            }
		
        }
        static void M2()   // it is not allowing duplicates
        {
            for(int i = 0; i < 10; i++)
            {
               Console.WriteLine( cd.TryAdd(i, "M2.added" + i)+" M2");
            }
            foreach (var s in cd)  // printing added elements to ConDis
            {
                Console.Write(s+" ");
            }
        }
    }
}
