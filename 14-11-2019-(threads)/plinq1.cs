using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class ForEach
{
  public static void Main()
    {       
		var list = new List<int>{ 4, 1, 6, 2, 9, 5, 10, 3};	  
        int sum = 0;
        try
        {
            Parallel.ForEach( list,() => 0, (n, loopState, localSum) =>
                    {
                        localSum += n;
                        Console.WriteLine("Thread={0}, n={1}, localSum={2}", Thread.CurrentThread.ManagedThreadId, n, localSum);
                        return localSum;
                    },
                    (localSum) => Interlocked.Add(ref sum, localSum)	
                );

            Console.WriteLine("\nSum="+ sum);
        }
        
        catch (AggregateException e)
        {
            Console.WriteLine("ForEach has thrown an exception.", e);
        }
    }

}