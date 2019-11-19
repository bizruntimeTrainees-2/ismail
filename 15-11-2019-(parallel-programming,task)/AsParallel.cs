using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Class
    {
public class Linqs
{
	public static void Main(){
 var source = Enumerable.Range(1, 500);

//  PLINQ with AsParallel.
var evenNums = from num in source.AsParallel()
               where num % 2 == 0 && num <100 
               select num;
//without AsParallel
var evenNums1 = from num in source
               where num % 2 == 0 && num <10 
               select num;
Console.WriteLine("{0} even numbers out of {1} total",
                  evenNums.Count(), source.Count());

		foreach(int s in evenNums){
			Console.WriteLine(s);
		}
		Console.WriteLine();
		foreach(int s in evenNums1){
			Console.WriteLine(s);
		}
}
}

}