using System;
using System.Threading;
using System.Collections.Concurrent;
namespace BlockingCollection3
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            BlockingCollection<int> b = new BlockingCollection<int>(boundedCapacity: 5); //specifing the capacity
            b.Add(1);
            b.Add(2);
            b.Add(3);
            b.Add(4);
            b.Add(5);
           
            int item = b.Take();
            Console.WriteLine(item);
        }
    }
}
