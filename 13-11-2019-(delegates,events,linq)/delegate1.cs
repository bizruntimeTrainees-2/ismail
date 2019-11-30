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
        TestDelegate testA = new TestDelegate(M);

        TestDelegate testB = delegate(string s) { Console.WriteLine(s); };

        TestDelegate testC = (x) => { Console.WriteLine(x); };

        testA("Hello. My name is M and I write lines.");
        testB("That's nothing. I'm anonymous and ");
        testC("I'm a famous author.");

        Console.WriteLine();
       
    }
}
Pathanismail182