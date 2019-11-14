using System;
using System.Threading;

public class Example
{
 
   
   public static void Main()
   {
      ThreadPool.QueueUserWorkItem(T1);
      var th1 = new Thread(T1);
      th1.Start();
      var th2 = new Thread(T1);
      th2.IsBackground = true;
      th2.Start();
      Thread.Sleep(500);
      T1(null); 
   }
   
   private static void T1(Object state)
   {
	   Object obj = new Object();
      lock (obj) {
         var th  = Thread.CurrentThread;
         Console.WriteLine("Managed thread "+ th.ManagedThreadId+" "+ th.IsBackground+" "+th.IsThreadPoolThread+" "+th.Priority);
         Console.WriteLine("Culture:"+th.CurrentCulture.Name);
         Console.WriteLine("thread state:"+Thread.CurrentThread.ThreadState);
		  Console.WriteLine();
      }   
   }
}
