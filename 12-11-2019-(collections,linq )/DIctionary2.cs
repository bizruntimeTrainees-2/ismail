using System;
using System.Collections.Generic;
namespace CollectionsDc
{
    public class DictionaryD
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dis = new Dictionary<string, string>();
            dis.Add("txt","value1");
            dis.Add("doc","value2");
            dis.Add("pdf","value3");
            dis.Add("html","value4");
            try
            {
                dis.Add("txt","value5");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("adding key is already present");
            }
           Console.WriteLine("for Key txt value: "+ dis["txt"]);
           dis["txt"] = "value5";
               Console.WriteLine("for Key txt changed value: "+ dis["txt"]);
			Console.WriteLine();
               try
               {
                Console.WriteLine("searching for key : "+ dis["dam"]);
               }
               catch (KeyNotFoundException)
               {
                           Console.WriteLine("searching key is not present");
               }
			Console.WriteLine();
               string val="";
               if (dis.TryGetValue("text", out val))
               {
                   Console.WriteLine("key value : "+ val);
               }
               else
                   Console.WriteLine("key is not found");
			Console.WriteLine();
               if (!dis.ContainsKey("http"))
               {
                   dis.Add("http","Hello");
                   Console.WriteLine("value for added key: "+ dis["http"]);
               }
               else 
                    Console.WriteLine("key is already present");
			Console.WriteLine();
               foreach (KeyValuePair<string, string> kvp in dis)
               {
                   Console.WriteLine("key:"+ kvp.Key +"value: "+ kvp.Value);
               }
               Dictionary<string,string>.ValueCollection lval  = dis.Values;                                       //this is differ from sortedlist
             Console.WriteLine();
               foreach (string values in lval)
               {
                   Console.WriteLine("values: "+ values);
               }
               Console.WriteLine("retrieving through values: "+ dis.ContainsValue("Hello"));
               Console.WriteLine();
               Dictionary<string, string>.KeyCollection lkeys  = dis.Keys;                                                   // this is differ from sortedlist
             Console.WriteLine();
               foreach (string key in lkeys)
               {
                   Console.WriteLine("keys: "+ key);
               }
             Console.WriteLine("retrieving through values: "+ dis.ContainsKey("http"));
			Console.WriteLine();
               dis.Remove("txt");
               if (!dis.ContainsKey("txt"))
               {
                          Console.WriteLine("key is not found");
               }
        }
    }
}