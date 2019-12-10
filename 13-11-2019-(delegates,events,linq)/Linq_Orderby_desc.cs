using System;
using System.Linq;
using System.Collections;

public class Program
{
	public static void Main(string[] args)
	{
		IList list = new ArrayList();
		list.Add(0);
		list.Add("One");
		list.Add("abc");
		list.Add("bye");
		list.Add("Two");
		list.Add(3);
		list.Add(2);
		list.Add(20);
		
		var stringResult = from s in list.OfType<string>()
                                            orderby s  
						                       select s;
		
		var intResult = from s in list.OfType<int>()
                                      orderby s descending
			            			   select s;
		
		
		foreach (var str in stringResult)
        	Console.WriteLine(str);
		
		foreach (var integer in intResult)
        	Console.WriteLine(integer);		
	}
}

