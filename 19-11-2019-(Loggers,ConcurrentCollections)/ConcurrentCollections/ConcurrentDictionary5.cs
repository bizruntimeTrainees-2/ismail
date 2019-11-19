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

            cd.TryAdd("watch", 2);
            cd.TryAdd("hand", 4);

            cd.TryUpdate("watch", 500, 2);
            cd.TryUpdate("watch", 300, 5);
            Console.WriteLine(cd["watch"]);

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
