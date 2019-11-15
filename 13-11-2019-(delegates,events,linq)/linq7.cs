using System;
namespace Class{
using System.Collections.Generic;
using System.Collections;
using System.Linq;
public class Linqs
{
	public static void Main(){
  IList<Student> studentList = new List<Student>() { 
				new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 } 
			};
		
		IList<Standard> standardList = new List<Standard>() { 
				new Standard(){ StandardID = 1, StandardName="Standard 1"},
				new Standard(){ StandardID = 2, StandardName="Standard 2"},
				new Standard(){ StandardID = 3, StandardName="Standard 3"}
			};
		
		var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                s => s.StandardID,     //innerKeySelector
                                (std, studentsGroup) => new // resultSelector 
                                {
                                    students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });

		foreach (var item in groupJoin)
		{ 
			Console.WriteLine(item.StandarFulldName );
			foreach (var str in item.StandarFulldName)
		{ 
			Console.WriteLine(str);
						
		}
		}
		
}
}
public class Student{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }
	public int StandardID { get; set; }
}

public class Standard{

	public int StandardID { get; set; }
	public string StandardName { get; set; }
}
}