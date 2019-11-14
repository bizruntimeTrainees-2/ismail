using System;
using System.Threading;
using System.Threading.Tasks;

public class Tasks1
{
	public static void Main()
	{
		Thread.CurrentThread.Name ="Main";
		//Task task = new Task(()=> Console.WriteLine("I'm from Task"));
	    Task task = Task.Run(()=> Console.WriteLine("I'm from Task"));
		//task.Start();
		Console.WriteLine("hello from thread"+Thread.CurrentThread.Name);
		task.Wait();
	}
}
