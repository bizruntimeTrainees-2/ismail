using System;
using System.Threading;
using System.Threading.Tasks;

public class Class1
{
    public static  void Main()
    {
        var tasks = new Task[3];
        var rnd = new Random();
        for(int cts = 0; cts < 3; cts++)
        {
            tasks[cts] = Task.Run(() => Thread.Sleep(rnd.Next(1000, 5000)));
        }
        try
        {
            var index = Task.WaitAny(tasks);//WaitAll for which thread will wait for completion of all threads.
            Console.WriteLine("task{0} completed first", tasks[index].Id);
            Console.WriteLine("task status:");
            foreach(var s in tasks)
            {
                Console.WriteLine("task{0} :{1}",s.Id,s.Status);
            }
        }
        catch(AggregateException e)
        {
            Console.WriteLine("exception raised in task"+e.Message);
        }
    }
}
