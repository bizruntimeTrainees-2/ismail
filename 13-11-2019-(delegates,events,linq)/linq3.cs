using System;
					
public class Program
{
	delegate bool IsTeenAger(Student stud);
	
	public static void Main()
	{
		//IsTeenAger isTeenAger = delegate(Student s) { return s.Age > 12 && s.Age < 20; };
		IsTeenAger isTeenAger = (s)=> s.Age > 12 && s.Age < 20; 
		
		Student stud = new Student() { Age = 19 };
		
		Console.WriteLine(isTeenAger(stud));
	}
}

public class Student{

	public int Id ;
	public string Name ;
	public int Age ;
}