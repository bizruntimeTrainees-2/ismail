using System;
using System.Threading;

public class Example
{ 
   public static void Main(string[] args)
   {
          
	  //Queues a method or task for execution .Whenever thread pool thread is available
	  ThreadPool.QueueUserWorkItem(T1);
	  
	   T1(null); 
	  
	   Thread th1 = new Thread(T1);
       th1.Start();
       Thread th2 = new Thread(T1);

      //thread will run in ground
      th2.IsBackground = true;

      th2.Start();
      Thread.Sleep(500);
     
   }
   
   private static void T1(Object state)
   {
	   Object obj = new Object();
      lock (obj) {
         var th  = Thread.CurrentThread;
         Console.WriteLine("Managed thread "+ th.ManagedThreadId+" "+ th.IsBackground+" "+th.IsThreadPoolThread+" "+th.Priority);        
		  Console.WriteLine();
      }   
   }
}
