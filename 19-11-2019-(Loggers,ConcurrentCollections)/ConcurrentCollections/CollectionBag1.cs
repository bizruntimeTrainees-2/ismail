using System;
using System.Threading;
using System.Collections.Concurrent;
namespace ConcurrentBag1
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(1);
            bag.Add(110);
            bag.Add(22);

            int result;
            if(bag.TryPeek(out result))     //it returns the most recently added element
            {
                Console.WriteLine("TryPeek: " + result);
            }
            if(bag.TryTake(out result))     //it returns and removes the most recently added element
            {
                Console.WriteLine("TryTake: " + result);
            }
            if (bag.TryPeek(out result))
            {
                Console.WriteLine("TryPeek: " + result);
            }

        }
    }
}
