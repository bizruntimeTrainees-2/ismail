using System;
using System.Linq;
using System.Collections.Generic;

					
public class Test
{
	public static void Main(string[] args)
	{
		IList<Student> studentList = new List<Student>() { 
				new Student() { id = 1, name = "John", Age = 13} ,
				new Student() { id = 2, name = "money",  Age = 21 } ,
				new Student() { id = 3, name = "banny",  Age = 18 } ,
				new Student() { id = 4, name = "Ram" , Age = 20} ,
				new Student() { id = 5, name = "Ramu" , Age = 15 } 
			};
		
		var teenAgerStudent = from s in studentList
							  where s.Age > 12 && s.Age < 20
							  select s;
          
		Console.WriteLine("Teen age Students:");
						  
		foreach(Student std in teenAgerStudent){			
			Console.WriteLine(std.id+" "+std.name);
		}
	}
}

public class Student{

	public int id { get; set; }
	public string name { get; set; }
	public int Age { get; set; }
	
}