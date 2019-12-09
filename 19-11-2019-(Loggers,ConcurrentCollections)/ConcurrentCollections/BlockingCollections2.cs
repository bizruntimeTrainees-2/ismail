using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace BlockingCollections
{
    public class BCollections
    {
        public static void Main(string[] args)
        {
            BlockingCollection<int>  bCollection = new BlockingCollection<int>(boundedCapacity:10);
           Task producerThread = Task.Factory.StartNew( () => {
               for (int i = 0; i < 10 ; i++ )
               {
                   bCollection.Add(i);
               }
               bCollection.CompleteAdding();
           });
           Task consumerThread = Task.Factory.StartNew( () => {
               while (!bCollection.IsCompleted)
               {
                   int item = bCollection.Take();
                   Console.WriteLine(item);
               }
           });
           Task.WaitAll(producerThread, consumerThread);
           /*
           foreach (int item in bCollection.GetConsumingEnumerable())
           {
               Console.WriteLine(item +":  item is removed");
           }
         */   
        }
    }
}