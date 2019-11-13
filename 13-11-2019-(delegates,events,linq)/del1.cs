using System;
public class Test
{
    delegate void TestDelegate(string s);
    static void M(string s)
    {
        Console.WriteLine(s);
    }

   public  static void Main(string[] args)
    {
        // Original delegate syntax required 
        // initialization with a named method.
        TestDelegate testDelA = new TestDelegate(M);

        // inline code, called an "anonymous method." This
        // method takes a string as an input parameter.
        TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };

        TestDelegate testDelC = (x) => { Console.WriteLine(x); };

        testDelA("Hello. My name is M and I write lines.");
        testDelB("That's nothing. I'm anonymous and ");
        testDelC("I'm a famous author.");

        Console.WriteLine();
       
    }
}
Pathanismail182