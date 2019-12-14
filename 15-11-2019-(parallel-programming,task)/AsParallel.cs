using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace AsParallelProgram {
public class Linqs
{
	public static void Main(string[] args)
	{
		var source = Enumerable.Range(1, 100);

		//  PLINQ with AsParallel.
		var evenNums = from num in source.AsParallel()
						where num % 2 == 0 && num > 50&& num <100 
						select num;
		//without AsParallel
		var evenNums1 = from num in source
						where num % 2 == 0 && num <=100 
						select num;
		Console.WriteLine("{0} even numbers out of {1} total",
							evenNums1.Count(), source.Count());

		foreach(int s in evenNums)
		{
			Console.WriteLine(s);
		}
		Console.WriteLine();
		foreach(int s in evenNums1)
		{
			Console.WriteLine(s);
		}
	}
}

}