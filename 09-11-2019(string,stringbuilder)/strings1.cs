using System;
public class Strings1
{
    public static void Main()
{
        string s1 = "hello";
        string s2 = "helol";
		
       Console.WriteLine(s1.CompareTo(s2));
		 Console.WriteLine(s2.CompareTo(s1));
		Console.WriteLine();
		Console.WriteLine(string.Compare(s2, s1));
		Console.WriteLine(string.Compare(s1, s2));
		Console.WriteLine(s2.Equals(s1));
}
}
