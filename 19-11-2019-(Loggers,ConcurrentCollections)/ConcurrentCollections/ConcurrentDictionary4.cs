using System;
using System.Collections.Concurrent;
using System.Linq;
namespace ConcurrentDictionary4
{
    public class Program
    {
        static ConcurrentDictionary<string,int>  cd = new ConcurrentDictionary<string,int>();
       public  static void Main(string[] args)
        {
            cd.TryAdd("glass", 1);
            cd.TryAdd("pot", 2);
            cd.TryAdd("date", 3);
            cd.TryAdd("place", 4);

            int removedItem;
           bool result =  cd.TryRemove("pot", out removedItem);
            Console.WriteLine(removedItem);
        }
    }
}
