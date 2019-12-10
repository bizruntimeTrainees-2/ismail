using System;
using System.Collections.Generic;
using System.Linq;
namespace Class
{
  public class Linqs
{
	public static void Main(string[] args){
        IList<string> strList1 = new List<string>(){"One", "Two", "Three", "Four", "Three"};

		IList<string> strList2 = new List<string>(){"One", "Two", "Three", "Four", "Three"};

		bool isEqual = strList1.SequenceEqual(strList2); // returns true
		Console.WriteLine(isEqual);

        var collection1 = strList1.Concat(strList2);
         foreach (string str in collection1)
           Console.WriteLine(str);

         IList<int> intList = new List<int>(){ 1, 2, 3, 2, 4, 4, 3, 5 };
            var distinctList1 = intList.Distinct();
             foreach(var str in distinctList1)
               Console.WriteLine(str);

             	var newList = strList1.Skip(2);
                 foreach(var str in newList)
              Console.WriteLine(str);

                 var newList1 = strList1.Take(2);
                foreach(var str in newList1)
                    Console.WriteLine(str);
	}
  }
}