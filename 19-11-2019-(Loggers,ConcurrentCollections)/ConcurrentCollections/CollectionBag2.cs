using System;
using System.Threading;
using System.Collections.Concurrent;
namespace ConcurrentBag2
{
    public class Program
    {
       public static void Main(string[] args)
        {
          //  string[] str = { "cat", "mat", "rat", "bat" };
            ConcurrentBag<string> bag = new ConcurrentBag<string>{ "cat", "mat", "rat", "bat" };//(str);

            string result;
            if(bag.TryPeek(out result))
            {
                Console.WriteLine("TryPeek:{0}" , result);
            }
            Console.WriteLine("Count:{0}" , bag.Count);
        }
    }
}
