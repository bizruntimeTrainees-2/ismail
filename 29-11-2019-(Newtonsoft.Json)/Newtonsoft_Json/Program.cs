using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft_Json
{
    class Program 
    {
        public string Employee { get; set; }
        public decimal Salary { get; set; }
        // false is default value of bool
        public bool Paid { get; set; }
        // null is default value of nullable
        public DateTime? PaidDate { get; set; }

        // customize default values
        [DefaultValue(30)]
        public int WorkingDays { get; set; }
        [DefaultValue("")]
        public string FollowUpEmailAddress { get; set; }
        static void Main(string[] args)
        {
            Program program = new Program()
            {
                Employee = "Rajesh",
                Salary = 10000,
                WorkingDays = 30,
                Paid = false,
                FollowUpEmailAddress = string.Empty,
                PaidDate = DateTime.Now
            };
            string included = JsonConvert.SerializeObject(program, Formatting.Indented, new JsonSerializerSettings { });
            Console.WriteLine(Environment.NewLine+ included);

            string ignored = JsonConvert.SerializeObject(program, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            Console.WriteLine(Environment.NewLine + ignored);

           
        }
    }
}
