using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;


namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            JsonConvertDemo.Show();
            Console.WriteLine("Serialization and deserialization done");
        }
    }
    public class JsonConvertDemo
    {
        private static string jsonRawData = @"{                                          
                                           'Name': 'Sid',
                                          'Courses': [
                                            'Course 1',
                                            'Course 2'
                                          ],
                                          'Since': '2017-03-01T22:09:39.9369001+00:00',
                                          'IsHappy': true,
                                          'Country': 'India',
                                          'Age': 25
                                        }";
                                       

        public static void Show()
        {
            Console.WriteLine("Json raw data:");
            Console.WriteLine( jsonRawData);

            var author = JsonConvert.DeserializeObject<Author>(jsonRawData);
            Console.WriteLine(Environment.NewLine+"Deserialized data:{0} \n",author + ","+ author.Age +","+ author.Courses[0]);

            var seralizedData = JsonConvert.SerializeObject(author);
            Console.WriteLine(Environment.NewLine+"Serialized data: \n" + seralizedData);

            var FormattedSeralizedData = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(Environment.NewLine+ "FormattedSeralized  data: \n" + FormattedSeralizedData);


            JObject jobj = JObject.Parse(jsonRawData);
            List<JToken> jTokens = jobj["Courses"].Children().ToList();
      
            foreach (JToken result in jTokens)
            {
               
                Console.WriteLine(result.ToString());
            }
           
        }

    }
    public class Author
    {
        public string Name { get; set; }

        public List<string> Courses { get; set; }

        public DateTimeOffset Since { get; set; }

        public bool IsHappy { get; set; }

        public string Country { get; set; }

        public int Age { get; set; }

        public List<Author> FavouriteAuthors { get; set; }

    }
   
}
