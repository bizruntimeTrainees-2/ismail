using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
namespace Linq_To_Json
{
    class Program
    {
        static void Main(string[] args)

        { 
            JArray array = new JArray();
            JValue text = new JValue("Manually created json");
            JValue date = new JValue(new DateTime(2019, 11, 30));

            array.Add(text);
            array.Add(date);
            string json = array.ToString();
            Console.WriteLine("process Done: "+ json);
            Console.ReadLine();

            var posts = from p in json
                        select p;


        }
    }
}
