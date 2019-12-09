using System;
using System.Threading;
using System.Collections.Concurrent;
namespace BlockingCollections
{
    public class BCollections
    {
        public static void Main(string[] args)
        {
            BlockingCollection<int>  bCollection = new BlockingCollection<int>(boundedCapacity:2);
             bCollection.Add(1);
             bCollection.Add(2);
             if (bCollection.TryAdd(3, TimeSpan.FromSeconds(2)))
             {
                 Console.WriteLine("item added");
             }
             else
                 Console.WriteLine("item does not added");

             int item = bCollection.Take();
                   item = bCollection.Take();
                   if (bCollection.TryTake(out item, TimeSpan.FromSeconds(2)))
                   {
                       Console.WriteLine(item);
                   }
                   else
                     {
                            Console.WriteLine(" no item is removed");
                    }
        }
    }
}