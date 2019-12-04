using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
namespace Linq_to_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            //get  the data in serializaion form
            string studentsData = JsonConvert.SerializeObject(new StudentDataBase(), Formatting.Indented);
            Console.WriteLine(studentsData);
            Console.WriteLine();
            //convert the json string into an array
            JArray studentsArray = JArray.Parse(studentsData);

            //read all student names
            var  resStudentNames = (from s in studentsArray
                                    select s["studentName"]).ToList();

            Console.WriteLine("Only student Names");
            foreach(var name in resStudentNames)
            {
                Console.WriteLine(name.Value<string>().ToString());
            }
            Console.WriteLine();
            //read all student Academic year
            var resStudentAcaYear = (from s in studentsArray
                                     select s["studentId"]).ToList();
            Console.WriteLine("Only student Academic year");

            foreach (var year in resStudentAcaYear)
            {
                Console.WriteLine(year.Value<string>().ToString());
            }
            Console.WriteLine();
            //read student courses
            var resStudentCourses = (from s in studentsArray.Children()["courses"]
                                     select s).ToList();
            Console.WriteLine("Courses");
             foreach(var course in resStudentCourses.Children().ToList())
            {
                Console.WriteLine(course.ToObject<Course>().courseId + "\t" + course.ToObject<Course>().courseName);
            }
            Console.WriteLine();
            //get Employee data by serialization form
            string employeeData = JsonConvert.SerializeObject(new EmployeeDatabase(), Formatting.Indented);

            //6. Convert the JSON string into an Array
            JArray employeesArray = JArray.Parse(employeeData);

            var empGroupByDepartment = from e in employeesArray
                                       group e by e["Department"] into deptGroup
                                       select new
                                       {
                                           DeptName = deptGroup.Key,
                                           EmpCount = deptGroup.Count()

                                       };
            Console.WriteLine("Department \t Total Employees");
            foreach(var dept in empGroupByDepartment)
            {
                Console.WriteLine(dept.DeptName +"\t\t"+ dept.EmpCount );
            }
            Console.WriteLine();
            Dictionary<string, int> points = new Dictionary<string, int>
             {
                     { "AAA", 9001 },
                      { "BBB", 3474 },
                     { "CCC", 11926 }

             };
            string json = JsonConvert.SerializeObject(points, Formatting.Indented);

            File.WriteAllText(@"c:\jsonfile.json", JsonConvert.SerializeObject(points));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"c:\jsonfile.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, points);
            }

            Console.WriteLine(json);
            Console.WriteLine("Done");

        }
    }
}
