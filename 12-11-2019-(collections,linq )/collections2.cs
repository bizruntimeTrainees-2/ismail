using System;
using System.Collections.Generic;

public class CollectionsQ
{
    public static void Main()
    {
        Queue <string> que = new Queue<string>();
        que.Enqueue("one");
        que.Enqueue("two");
        que.Enqueue("three");
        que.Enqueue("four");
        que.Enqueue("five");
        
        foreach (string number in que)
        {
            Console.Write(number+"\t");
        }
        
       Console.WriteLine("\nreading element: "+que.Peek());
       Console.WriteLine("removing element: "+que.Dequeue());
         Console.WriteLine("reading element: "+que.Peek());

         Queue<string> quecopy1 = new Queue<string>(que.ToArray());
            Console.WriteLine("\nreading first time: ");
        foreach (string number in quecopy1)
        {
            Console.Write(number+"\t");
        }
        string[] array = new string[quecopy1.Count*2];
        que.CopyTo(array, que.Count);
         Queue<string> quecopy2 = new Queue<string>(array);
            Console.WriteLine("\nreading second time: ");
          foreach (string number in quecopy2)
        {
            Console.Write(number+"\t");
        }
       Console.WriteLine("\n checking element: "+quecopy1.Contains("three"));
		 Console.WriteLine("\n checking element: "+quecopy2.Contains(null));
		 Console.WriteLine("\n checking element: "+quecopy2.Count);
		quecopy2.Clear();
		 Console.WriteLine("\n checking element: "+quecopy2.Count);
    }
}

