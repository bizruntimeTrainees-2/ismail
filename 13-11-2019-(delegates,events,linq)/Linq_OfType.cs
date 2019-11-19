using System;
using System.Linq;
using System.Collections;

public class Program
{
	public static void Main()
	{
		IList list = new ArrayList();
		list.Add(0);
		list.Add("One");
		list.Add("Two");
		list.Add(3);
		
		var stringResult = from s in list.OfType<string>()
						   select s;
		
		var intResult = from s in list.OfType<int>()
						   select s;
		
		
		foreach (var str in stringResult)
        	Console.WriteLine(str);
		
		foreach (var integer in intResult)
        	Console.WriteLine(integer);
		
	
		
	}
}

