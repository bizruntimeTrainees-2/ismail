using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_to_Json
{
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
    }
    public class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string AcademicYear { get; set; }
        public List<Course> courses { get; set; }
    }
    public class StudentDataBase : List<Student>
    {
        public  StudentDataBase()
        {
            Add(new Student()
            {
                studentId = 10,
                studentName = "Hari",
                AcademicYear = "first",
                courses = new List<Course>()
                {
                    new Course() {courseId=101,courseName="C++" },
                    new Course() {courseId=102,courseName="C" },
                    new Course() {courseId=103,courseName="Visual Basic" }

                }
            });
            Add(new Student()
            {
                studentId = 20,
                studentName = "rajesh",
                AcademicYear = "second",
                courses = new List<Course>()
                {
                    new Course() {courseId=104,courseName="Spring" },
                    new Course() {courseId=105,courseName="Hibernate" },
                    new Course() {courseId=106,courseName="Visual Basic" }

                }
            });
            Add(new Student()
            {
                studentId = 30,
                studentName = "raju",
                AcademicYear = "third",
                courses = new List<Course>()
                {
                    new Course() {courseId=107,courseName="C#" },
                    new Course() {courseId=108,courseName="MVC" },
                    new Course() {courseId=109,courseName="VS Code" }

                }
            });
            Add(new Student()
            {
                studentId = 10,
                studentName = "Ramesh",
                AcademicYear = "Fourth",
                courses = new List<Course>()
                {
                    new Course() {courseId=110,courseName="Java" },
                    new Course() {courseId=112,courseName="Anguar" },
                    new Course() {courseId=113,courseName="Visual Studio" }

                }
            });
        }
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
    }
    public class EmployeeDatabase : List<Employee>
    {
        public EmployeeDatabase()
        {
            Add(new Employee() { EmpId = 1, EmpName = "A", Department = "IT" });
            Add(new Employee() { EmpId = 2, EmpName = "B", Department = "Non-IT" });
            Add(new Employee() { EmpId = 3, EmpName = "C", Department = "Network" });          
        }
    }
}
