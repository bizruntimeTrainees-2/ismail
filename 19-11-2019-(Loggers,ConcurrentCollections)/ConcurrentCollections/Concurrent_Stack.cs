using System;
using System.Threading;
using System.Collections.Concurrent;
namespace ConcurrentStack1
{
    public class Program
    {
      public   static void Main(string[] args)
        {
            int[] elements = { 0, 10, 20, 40 };
            ConcurrentStack<int> stack = new ConcurrentStack<int>(elements);
            Console.WriteLine(string.Join(",", stack.ToArray()));

            stack.Push(50);         //adding new element to the stack
            Console.WriteLine(string.Join(",", stack.ToArray()));

           
            if(stack.TryPeek(out int resultPeek))       //get the top most element
            {
                Console.WriteLine("TryPeek result:"+ resultPeek);
            }
            if(stack.TryPop(out  int resultPop))             //get and remove top most element
            {
                Console.WriteLine("TryPop result:"+ resultPop);
            }
            Console.WriteLine(string.Join(",", stack.ToArray()));
        }
    }
}
