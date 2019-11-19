using System;
using System.Threading;
using System.Diagnostics;
public class T
{
	
	public static void Main(string[] args)
	{
	
		Thread th = new Thread(ExecuteInForeground);
		th.Start(5000);
		Thread.Sleep(10);
		
			Console.WriteLine("from Main thread: "+Thread.CurrentThread.ManagedThreadId);
			
		Console.WriteLine("main thread ends.");
	}
	static void ExecuteInForeground(Object obj)
	{
		int time;
		try 
		{
			time = (int)obj;
		}
		catch(InvalidCastException e)
		{
			Console.WriteLine("raised exception handled" + e.Message);
			time = 5000;
		}
		Console.WriteLine("foreground thread status: "+Thread.CurrentThread.ManagedThreadId+" "+
						 Thread.CurrentThread.ThreadState+" "+
						 Thread.CurrentThread.Priority);
	}
}

