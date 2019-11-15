using System;
using System.Threading;
public class Class1
{
	public static void Main()
    {
        int[] array = Enumerable.Range(1, 500).ToArray();
        var cts = new CancellationTokenSource();

        Task.Factory.StartNew(() => {
            UserClickedTheCancellationButton(cts);
            });
        double[] results = null;
        try
        {
            results = (from num in array.AsParallel().WithCancellation(cts.Token)
                       where num % 2 != 0
                       select Function(num, cts.Token)).ToArray();
        }
        catch(OperationCanceledException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(AggregateException ae)
        {
            if(ae.InnerExceptions != 0)
            {
                foreach(var s in ae.InnerExceptions)
                {
                    Console.WriteLine(s.Message);
                }

            }
        }
        finally
        {
            cts.Dispose();
        }
           if(results != null)
        {
            foreach(var s in results)
            {
                Console.WriteLine(s.ToString);
            }
        }
        Console.WriteLine();
        Console.ReadKey();
    }
    static double Function(int n, CancellationToken ct)
    {
        for(int i=0; i < 5; i++)
        {
            Thread.SpinWait(50000);
            ct.ThrowIfCancellationRequested();
        }
        return Math.Sqrt(n);
    }
    static void UserClickedTheCancellationButton(CancellationTokenSource cts)
    {
        Random ran = new Random();
        Thread.Sleep(ran.Next(150, 250));
        Console.WriteLine("press 'c' to cancle ");
        if (Console.ReadKey().KeyChar == c)
        {
            cts.Cancel();
        }
    }
}
