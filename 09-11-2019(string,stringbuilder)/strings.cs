using System;
public class Strings1
{
    public static void Main()
{
        string s1 = "   hello to all  ";
        string[] s2 = s1.Split(' ');
		 string s3 = "hello to all";
        foreach(string s in s2)
    {
            Console.WriteLine(s.ToString());
    }
	Console.WriteLine(s1.Trim());
    Console.WriteLine(s1.IndexOf("t"));
    Console.WriteLine(s1.Contains("helo"));
	Console.WriteLine(s1.Equals(s3));
       Console.WriteLine();
}
}
