using System;
namespace Class{
using System.Collections.Generic;
using System.Collections;
using System.Linq;
public class Linqs
{
	public static void Main(){
   IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron"  } 
};

IList<Standard> standardList = new List<Standard>() { 
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

var innerJoin = studentList.Join(// outer sequence 
                      standardList,  // inner sequence 
                      std => std.StudentID,    // outerKeySelector
                      str => str.StandardID,  // innerKeySelector
                      (student, standard) => new  // result selector
                                    {
                                        StudentName = student.StudentName,
                                        StandardName = standard.StandardName
                                    });
		foreach(var str in innerJoin )
				{
			Console.WriteLine(str);
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