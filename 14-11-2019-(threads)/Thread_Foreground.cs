using System;
using System.Threading;

public class ThreadExample
{
	
	public static void Main(string[] args)
	{
	
		var th = new Thread(ExecuteInForeground);
		th.Start();
		Thread.Sleep(1000);
		
	    Console.WriteLine("from Main thread: "+Thread.CurrentThread.ManagedThreadId);
			
		Console.WriteLine("main thread ends.");
	}
	static void ExecuteInForeground()
	{
		Console.WriteLine("foreground thread status: "+
		                  Thread.CurrentThread.ManagedThreadId+" "+
						 Thread.CurrentThread.ThreadState+" "+
						 Thread.CurrentThread.Priority);
		
	}
}

