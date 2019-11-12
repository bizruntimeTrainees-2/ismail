using System;
using System.Collections.Generic;
namespace CollectionsSet
{
    public class Hashset
    {
        public static void Main()
        {
            HashSet<int> hs1 = new HashSet<int>();
            HashSet<int> hs2 = new HashSet<int>();
              for (int i =0; i < 5 ; i++ )
              {
                  hs1.Add(i*2);
                  hs2.Add((i*2)+1);
              }
              Console.WriteLine("count of even numbers" + hs1.Count);
              DisplaySet(hs1);
              Console.WriteLine("count of odd numbers" + hs2.Count);
              DisplaySet(hs2);
               HashSet<int> hs3 = new HashSet<int>();
               hs3.UnionWith(hs1);
                hs3.UnionWith(hs2);
                Console.WriteLine("count of new numbers" + hs3.Count);
              DisplaySet(hs3);
			Console.WriteLine();
              hs3.ExceptWith(hs1);		
			DisplaySet(hs3);
			Console.WriteLine();
			 hs3.SymmetricExceptWith(hs1);
			DisplaySet(hs3);
			Console.WriteLine();
			hs3.IntersectWith(hs1);
			DisplaySet(hs3);
        }
static void DisplaySet(HashSet<int> set)
{
    Console.Write("{");
    foreach (int i in set)
    {
        Console.Write(i+" ");
    }
    Console.WriteLine(" }");
}
    }
}