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
        TestDelegate testDelA = new TestDelegate(M);

        TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };

        TestDelegate testDelC = (x) => { Console.WriteLine(x); };

        testDelA("Hello. My name is M and I write lines.");
        testDelB("That's nothing. I'm anonymous and ");
        testDelC("I'm a famous author.");

        Console.WriteLine();
       
    }
}
Pathanismail182