using System;
using System.Collections.Generic;
using System.Collections;
namespace CollectionsSL
{
    public class HashTable
    {
        public static void Main(string[] args)
        {
            Hashtable  hts = new Hashtable();
            hts.Add("txt","value1");
            hts.Add("doc","value2");
            hts.Add("pdf","value3");
            hts.Add("html","value4");
            try
            {
                hts.Add("txt","value5");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("adding key is already present");
            }
           Console.WriteLine("for Key txt value: "+ hts["txt"]);
           hts["txt"] = "value5";
               Console.WriteLine("for Key txt changed value: "+ hts["txt"]);
			Console.WriteLine();
               try
               {
                Console.WriteLine("searching for key : "+ hts["dam"]);
               }
               catch (KeyNotFoundException)
               {
                           Console.WriteLine("searching key is not present");
               }
		
			Console.WriteLine();
             
        foreach(DictionaryEntry de in hts )                                                             //here is some different from sortedlist/dictionary
        {
            Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
        }
               ICollection lval  = hts.Values;                                                                         // this si some different
             Console.WriteLine();
               foreach (string values in lval)
               {
                   Console.WriteLine("values: "+ values);
               }
               Console.WriteLine("retrieving through values: "+ hts.ContainsValue("Hello"));
               Console.WriteLine();
               ICollection lkeys  = hts.Keys;                                                                                 // this is some diferent
             Console.WriteLine();
               foreach (string key in lkeys)
               {
                   Console.WriteLine("keys: "+ key);
               }
             Console.WriteLine("retrieving through values: "+ hts.ContainsKey("http"));
			Console.WriteLine();
               hts.Remove("txt");
               if (!hts.ContainsKey("txt"))
               {
                          Console.WriteLine("key is not found");
               }
        }
    }
}//Hashtable doesn't contain TryGetValue() to get value