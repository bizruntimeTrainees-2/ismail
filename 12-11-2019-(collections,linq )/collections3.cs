using System;
using System.Collections.Generic;
namespace CollectionsSL
{
    public class Sortedlist
    {
        public static void Main(string[] args)
        {
            SortedList<string, string> slist = new SortedList<string, string>();
            slist.Add("txt","value1");
            slist.Add("doc","value2");
            slist.Add("pdf","value3");
            slist.Add("html","value4");
            try
            {
                slist.Add("txt","value5");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("adding key is already present");
            }
           Console.WriteLine("for Key txt value: "+slist["txt"]);
           slist["txt"] = "value5";
               Console.WriteLine("for Key txt changed value: "+slist["txt"]);
			Console.WriteLine();
               try
               {
                Console.WriteLine("searching for key : "+ slist["dam"]);
               }
               catch (KeyNotFoundException)
               {
                           Console.WriteLine("searching key is not present");
               }
			Console.WriteLine();
               string val="";
               if (slist.TryGetValue("text", out val))
               {
                   Console.WriteLine("key value : "+ val);
               }
               else
                   Console.WriteLine("key is not found");
			Console.WriteLine();
               if (!slist.ContainsKey("http"))
               {
                   slist.Add("http","Hello");
                   Console.WriteLine("value for added key: "+ slist["http"]);
               }
               else 
                    Console.WriteLine("key is already present");
			Console.WriteLine();
               foreach (KeyValuePair<string, string> kvp in slist)
               {
                   Console.WriteLine("key:"+ kvp.Key +"value: "+ kvp.Value);
               }
               IList<string> lval  = slist.Values;                                                                  //this is differ from dictionary and others
             Console.WriteLine();
               foreach (string values in lval)
               {
                   Console.WriteLine("values: "+ values);
               }
               Console.WriteLine("retrieving through values: "+slist.Values[2]);
               Console.WriteLine();
               IList<string> lkeys  = slist.Keys;                                                                               //this is differ from dictionary and others
             Console.WriteLine();
               foreach (string key in lkeys)
               {
                   Console.WriteLine("keys: "+ key);
               }
               Console.WriteLine("retrieving through values: "+slist.Keys[2]);
			Console.WriteLine();
               slist.Remove("txt");
               if (!slist.ContainsKey("txt"))
               {
                          Console.WriteLine("key is not found");
               }
        }
    }
}