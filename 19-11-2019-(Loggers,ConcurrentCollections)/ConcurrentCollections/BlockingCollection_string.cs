using System;
using System.Threading;
using System.Collections.Concurrent;
namespace BCollection2
{
    public class Program
    {
       public static void Main(string[] args)
        {
            BlockingCollection<string> b = new BlockingCollection<string>();
            b.Add("one");
            b.Add("two");
            b.Add("three");
            b.Add("four");
            b.Add("five");
           
            string item = b.Take(); //it removes the first element
            Console.WriteLine(item);
		   foreach(string s in b){
			   Console.Write(s+" ");
               }
        }
    }
}
