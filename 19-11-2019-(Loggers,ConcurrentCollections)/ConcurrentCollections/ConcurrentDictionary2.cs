using System;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace ConcurrentDictionary2
{
    public class Program
    {
       static ConcurrentDictionary<string, int> cd = new ConcurrentDictionary<string, int>();
     public   static void Main(string[] args)
        {
            Thread t1 = new Thread(T);
            Thread t2 = new Thread(T);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Average{0}" ,cd.Values.Average());
        }
        static void T()
        {
            for(int i = 0; i <= 5; i++)
            {
                cd.TryAdd(i.ToString(), i);
            }
        }
    }
}
