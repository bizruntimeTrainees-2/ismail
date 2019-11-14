using System;
using System.Threading;


public class T
{
	 static void T1(Object state)
	{	
		 for(int i=0; i< 5; i++)
		{
			Console.WriteLine("this is from thread pool "+i);		
		 }
	}
	public static void Main()
	{
		Console.WriteLine("Main thread start:");
		ThreadPool.QueueUserWorkItem(T1);
		Thread.Sleep(10);
		for(int i=50; i< 55; i++)
		{
			Console.WriteLine("from Main thread: "+i);
		}		
		Console.WriteLine("main thread ends.");
	}
}

