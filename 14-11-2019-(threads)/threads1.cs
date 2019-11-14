using System;
using System.Threading;


public class T
{
	public static void T1()
	{
		for(int i=0; i< 5; i++)
		{
			Console.WriteLine("from child thread: "+i);
		}
	}
	public static void Main()
	{
		Console.WriteLine("Main thread start:");
		Thread t = new Thread(new ThreadStart(T1));
		t.Start();
		t.Join();
		for(int i=50; i< 55; i++)
		{
			Console.WriteLine("from Main thread: "+i);
		}
		
		
		Console.WriteLine("main thread ends.");
	}
}

