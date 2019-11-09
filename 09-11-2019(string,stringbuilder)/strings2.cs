using System;
using System.Text;
public class Strings
{
    public static void Main(string[] args)
    {
        String str = "java and c#";
         StringBuilder sb  = new StringBuilder(str);
      
            Console.WriteLine(sb.AppendFormat(" baiscs",1));
		 Console.WriteLine(sb.Insert(10, "lang"));
		Console.WriteLine(sb.Remove(0,2));
		Console.WriteLine(sb.Insert(0,"ja"));
		Console.WriteLine(sb.Replace("lang",""));
    }
}