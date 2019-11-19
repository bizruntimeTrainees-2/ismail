using System;
using System.Threading;
using System.Collections.Concurrent;
namespace ConcurrentQueue1
{
    public class Program
    {
        static ConcurrentQueue<string> cq = new ConcurrentQueue<string>();
      public   static void Main(string[] args)
        {
            cq.Enqueue("student1");
            cq.Enqueue("student2");
            cq.Enqueue("student3");
            cq.Enqueue("student4");

            Console.WriteLine(string.Join(",", cq.ToArray()));

            string resultPeek;
            if(cq.TryPeek(out resultPeek))
            {
                Console.WriteLine("TryPeek: " + resultPeek);
            }
            string resultDequeue;
            if(cq.TryDequeue(out resultDequeue))
            {
                Console.WriteLine("TryDequeue: " + resultDequeue);
            }
            Console.WriteLine(string.Join(",",cq.ToArray()));
        }
    }
}
