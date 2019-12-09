using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace BlockingCollections
{
     class BCollections
    {
         static void Main(string[] args)
      {
        BlockingCollection<int>[] producers = new BlockingCollection[3];
        producers[0] = new BlockingCollection<int>(boundedCapacity: 10);
        producers[1] = new BlockingCollection<int>(boundedCapacity: 10);
        producers[2] = new BlockingCollection<int>(boundedCapacity: 10);
 
            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 10; ++i)
                {
                    producers[0].Add(i);
                    Thread.Sleep(100);
                }
                producers[0].CompleteAdding();
            });
 
        Task t2 = Task.Factory.StartNew(() =>
        {
            for (int i = 11; i <= 20; ++i)
            {
                producers[1].Add(i);
                Thread.Sleep(150);
             }
            producers[1].CompleteAdding();
        });
 
           Task t3 = Task.Factory.StartNew(() =>
         {
             for (int i = 21; i <= 30; ++i)
            {
                   producers[2].Add(i);
                    Thread.Sleep(250);
               }
                producers[2].CompleteAdding();
            });
 
            while (!producers[0].IsCompleted ||  !producers[1].IsCompleted ||  !producers[2].IsCompleted)
                  {
                       int item;
                       BlockingCollection<int>.TryTakeFromAny(producers, out item, TimeSpan.FromSeconds(5));
                        if (item != default(int))
                         {
                            Console.WriteLine(item);
                         }
           }
        }
    }
}