using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

public class Class1
{
    public static void Main()
    {
        int[] array = Enumerable.Range(1, 500).ToArray();
        var cts = new CancellationTokenSource();

        Task.Factory.StartNew(() => {
            UserClickedTheCancellationButton(cts);
        });
        int[] results = null;
        try
        {
            results = (from num in array.AsParallel().WithCancellation(cts.Token)
                       where num % 2 != 0
                       orderby num descending
                       select num).ToArray();
        }
        catch (OperationCanceledException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (AggregateException ae)
        {
            if (ae.InnerExceptions != null)
            {
                foreach (var s in ae.InnerExceptions)
                {
                    Console.WriteLine(s.Message);
                }

            }
        }
        finally
        {
            cts.Dispose();
        }
        if (results != null)
        {
            foreach (var s in results)
            {
                Console.WriteLine(s);
            }
        }
        Console.WriteLine("enter any key");
        Console.ReadKey();
    }

    static void UserClickedTheCancellationButton(CancellationTokenSource cts)
    {
        Random ran = new Random();
        Thread.Sleep(ran.Next(150, 250));
        cts.Cancel();
    }
}
