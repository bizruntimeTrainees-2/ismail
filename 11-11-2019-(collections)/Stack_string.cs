using System;
using System.Collections.Generic;

public class Example
{
    public static void Main(string[] args)
    {
        Stack<string> numbers = new Stack<string>();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        foreach( string number in numbers )
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Popping :"+ numbers.Pop());
        Console.WriteLine("read the element:"+  numbers.Peek());
        Console.WriteLine("Popping '{0}'", numbers.Pop());
        Stack<string> stack2 = new Stack<string>(numbers.ToArray());
        Console.WriteLine("Contents of the first copy:");
        foreach( string number in stack2 )
        {
            Console.WriteLine(number);
        }
        
        string[] array2 = new string[numbers.Count * 2];
        //copying stack to array2 contains null 
        numbers.CopyTo(array2, numbers.Count);
        //taking from array content to stack
        Stack<string> stack3 = new Stack<string>(array2);

        Console.WriteLine("Contents of the second copy, with duplicates and nulls:");
        foreach( string number in stack3 )
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("stack2.Contains('four') :"+   stack2.Contains("four"));

        Console.WriteLine("stack2.Clear()");
        //makes the stack empty
        stack2.Clear();
        Console.WriteLine("stack2.Count "+ stack2.Count);//0
    }
}


