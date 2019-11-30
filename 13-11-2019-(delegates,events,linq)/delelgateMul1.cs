using System;
namespace Dell
{
    delegate void Del(string s);
    public class Test
    {
        static void Method1(string s)
        {
            Console.WriteLine("hello from method1: " +s);
        }
        static void Method2(string s)
        {
            Console.WriteLine("hello from method2: " +s);
        }
        public static void Main()
        {
            Test t = new Test();
			Action<string> d1, d2, d3, d4;
            d1 = Method1;
             d2 = Method2;
             d3 = d1 + d2;
             d4 = d3 + d1;
           Console.WriteLine("from d1:"); 
            d1("A");
			Console.WriteLine("from d2:"); 
            d2("B");
			Console.WriteLine("from d3:"); 
            d3("C");
			Console.WriteLine("from d4:"); 
            d4("D");
    }
}
}