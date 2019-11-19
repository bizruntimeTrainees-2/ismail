using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
namespace BlockingCollection5
{
   public  class Program
    {
       public  static void Main(string[] args)
        {
            BlockingCollection<int> b = new BlockingCollection<int>();
            Task producerThread = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    b.Add(i);
                }
                b.CompleteAdding();
            });
            foreach(int item in b.GetConsumingEnumerable())
            {
                Console.WriteLine(item);
            }
        
        }
    }
}
