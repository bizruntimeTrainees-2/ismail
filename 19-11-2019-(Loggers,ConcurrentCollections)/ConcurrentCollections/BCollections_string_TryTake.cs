using System;
using System.Threading;
using System.Collections.Concurrent;
namespace BlockingCollection3
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            BlockingCollection<string> b = new BlockingCollection<string>(boundedCapacity:6); 
            b.Add("1");
            b.Add("2");
            b.Add("3");
            int item = b.Take();   //it removes first 
            Console.WriteLine(item);
         //  item = b.Take();                //removing second element
            Console.WriteLine(item);
            if (b.TryTake(out item, TimeSpan.FromSeconds(3)))
            {
                Console.WriteLine(item);   //item
            }
            else
            {
                Console.WriteLine("No item removed");
            }
        }
    }
}
