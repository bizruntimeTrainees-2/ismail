using System;
using System.Threading;
using System.Threading.Tasks;
public class Class1
{
    public static void Main(string[] args)
    {
        Action<Object> action = (Object obj) => {
            Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                                Task.CurrentId, obj,
                                 Thread.CurrentThread.ManagedThreadId);
        };
        Task t1 = new Task(action, "Hii");
          t1.Start();
        Task t2 = Task.Factory.StartNew(action, "hello", CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
     
      
        string data = "To Bangulore";
        Task t3 = Task.Run(() => {
            Console.WriteLine("Task={0}, obj={1},Thread={2},",
                              Task.CurrentId, data, Thread.CurrentThread.ManagedThreadId);
        });
       
        Task t4 = new Task(action, "form AP");
        t4.RunSynchronously();
        t4.Wait();
        t1.Wait();
        t3.Wait();
        t2.Wait();
      
    }
}
