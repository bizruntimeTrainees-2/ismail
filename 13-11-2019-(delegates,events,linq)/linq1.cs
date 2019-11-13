using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IList<string> stringList = new List<string>() {"Java",".net", "javascript" 	};
		
		var result = from s in stringList
					where s.Contains(".net") 
					select s;
		
		foreach (var str in result)
		{
			Console.WriteLine(str);
		}
	}
}