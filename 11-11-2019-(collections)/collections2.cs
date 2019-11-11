using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
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
        Console.WriteLine("Peek at next item to destack:"+  numbers.Peek());
        Console.WriteLine("Popping '{0}'", numbers.Pop());
        Stack<string> stack2 = new Stack<string>(numbers.ToArray());

        Console.WriteLine("Contents of the first copy:");
        foreach( string number in stack2 )
        {
            Console.WriteLine(number);
        }
        
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);//copying stack to array2 contains null 
        
        Stack<string> stack3 = new Stack<string>(array2);//taking from array content to stack

        Console.WriteLine("Contents of the second copy, with duplicates and nulls:");
        foreach( string number in stack3 )
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("stack2.Contains('four') :"+   stack2.Contains("four"));

        Console.WriteLine("stack2.Clear()");
        stack2.Clear();//makes the stack empty
        Console.WriteLine("stack2.Count "+ stack2.Count);//0
    }
}


