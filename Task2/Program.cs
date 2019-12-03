using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;
namespace EmployeeCreate
{
    public class CreateEmployee
    {
        public static void Main(string[] args)
        {

            List<Employee> listEmployee = CreateEmployee.CreateEmployees();
          
            CreateEmployeeList(listEmployee);
           
        }

        public static void CreateEmployeeList(List<Employee> listEmployee)
        {
            string csvPath = @"E:\Daily_Tasks\ismail\Task2\finalEmp.csv";
            string file1 = @"E:\Daily_Tasks\ismail\Task2\company1.txt";
            string file2 = @"E:\Daily_Tasks\ismail\Task2\company2.txt";
            string file3 = @"E:\Daily_Tasks\ismail\Task2\company3.txt";
            string file4 = @"E:\Daily_Tasks\ismail\Task2\company4.txt";
            string file5 = @"E:\Daily_Tasks\ismail\Task2\company5.txt";
            try
            {
                using (StreamWriter file = new StreamWriter(csvPath, true))
                {
                    file.WriteLine("Emp Name," + "Emp Id," + "Cmp Name," + "Cmp Id," + "Designation," + "Department");
                    foreach (Employee emp in listEmployee)
                    {
                        file.WriteLine(emp.employeeId + "," + emp.name + "," + emp.companyName + "," + emp.companyId +
                   "," + emp.designation + "," + emp.department);
                        Console.WriteLine(emp.employeeId + "," + emp.name + "," + emp.companyName + "," + emp.companyId +
                   "," + emp.designation + "," + emp.department);
                    }
                    Console.WriteLine("File has been created:");
                }

                using (StreamWriter file = new StreamWriter(file1, true))
                {
                    file.WriteLine("Emp Name," + "Emp Id," + "Cmp Name," + "Cmp Id," + "Designation," + "Department");
                    foreach (Employee emp in listEmployee)
                    {
                        if(emp.companyName =="HP")
                        {
                            file.WriteLine(emp.employeeId + "," + emp.name + "," + emp.companyName + "," + emp.companyId +
                                           "," + emp.designation + "," + emp.department);
                        }                       
                    }
                    Console.WriteLine("File1 has been created:");
                }
                using (StreamWriter file = new StreamWriter(file2, true))
                {
                    file.WriteLine("Emp Name," + "Emp Id," + "Cmp Name," + "Cmp Id," + "Designation," + "Department");
                    foreach (Employee emp in listEmployee)
                    {
                        if (emp.companyName == "Asus")
                        {
                            file.WriteLine(emp.employeeId + "," + emp.name + "," + emp.companyName + "," + emp.companyId +
                                           "," + emp.designation + "," + emp.department);
                        }
                    }
                    Console.WriteLine("File2 has been created:");
                }
                using (StreamWriter file = new StreamWriter(file3, true))
                {
                    file.WriteLine("Emp Name," + "Emp Id," + "Cmp Name," + "Cmp Id," + "Designation," + "Department");
                    foreach (Employee emp in listEmployee)
                    {
                        if (emp.companyName == "Lenovo")
                        {
                            file.WriteLine(emp.employeeId + "," + emp.name + "," + emp.companyName + "," + emp.companyId +
                                           "," + emp.designation + "," + emp.department);
                        }
                    }
                    Console.WriteLine("File3 has been created:");
                }
                using (StreamWriter file = new StreamWriter(file4, true))
                {
                    file.WriteLine("Emp Name," + "Emp Id," + "Cmp Name," + "Cmp Id," + "Designation," + "Department");
                    foreach (Employee emp in listEmployee)
                    {
                        if (emp.companyName == "Samsung")
                        {
                            file.WriteLine(emp.employeeId + "," + emp.name + "," + emp.companyName + "," + emp.companyId +
                                           "," + emp.designation + "," + emp.department);
                        }
                    }
                    Console.WriteLine("File4 has been created:");
                }
                using (StreamWriter file = new StreamWriter(file5, true))
                {
                    file.WriteLine("Emp Name," + "Emp Id," + "Cmp Name," + "Cmp Id," + "Designation," + "Department");
                    foreach (Employee emp in listEmployee)
                    {
                        if (emp.companyName == "Acer")
                        {
                            file.WriteLine(emp.employeeId + "," + emp.name + "," + emp.companyName + "," + emp.companyId +
                                           "," + emp.designation + "," + emp.department);
                        }
                    }
                    Console.WriteLine("File5 has been created:");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program did an oopsie ::", ex);
            }

        }
      
        public static List<Employee> CreateEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            int k = 0;
            int Empid = 10;
            while (k < 5)
            {
                string[] empName = { "Ramesh", "Rani", "Bhavesh", "Bishnu", "Chethan" };

                string[] compName = { "HP", "Lenovo", "Samsung", "Asus", "Acer" };
                int[] compid = { 10, 20, 30, 40, 50 };
                int j = 0;

                if (j < 5)
                {

                    for (int i = 0; i < 40; i++)
                {
                        Employee emp1 = new Employee()
                        {
                            name = empName[j],
                            employeeId = Empid,
                            companyName = compName[k],
                            companyId = compid[k],
                            designation = Employee.Designation.HardearEngineer,
                            department = Employee.Department.IT
                        };
                        employeeList.Add(emp1);
                        Empid++;
                        Employee emp2 = new Employee
                        {
                            name = empName[++j],
                            employeeId = Empid,
                            companyName = compName[k],
                            companyId = compid[k],
                            designation = Employee.Designation.Softwareengineer,
                            department = Employee.Department.HR
                        };
                        employeeList.Add(emp2);
                        Empid++;
                        Employee emp3 = new Employee
                        {
                            name = empName[++j],
                            employeeId = Empid,
                            companyName = compName[k],
                            companyId = compid[k],
                            designation = Employee.Designation.Systemsanalyst,
                            department = Employee.Department.Infrastructures
                        };
                        employeeList.Add(emp3);
                        Empid++;
                        Employee emp4 = new Employee
                        {
                            name = empName[++j],
                            employeeId = Empid,
                            companyName = compName[k],
                            companyId = compid[k],
                            designation = Employee.Designation.Technicalsupport,
                            department = Employee.Department.Researchanddevelopment
                        };
                        employeeList.Add(emp4);
                        Empid++;
                        Employee emp5 = new Employee
                        {
                            name = empName[++j],
                            employeeId = Empid,
                            companyName = compName[k],
                            companyId = compid[k],
                            designation = Employee.Designation.Webdeveloper,
                            department = Employee.Department.Salesandmarketing
                        };
                        employeeList.Add(emp5);
                        Empid++;
                   
                        j =0;
                    }
                   
                }
                k++;
            }

            return employeeList;
        }

    }

    public class Employee
    {
        public string name { get; set; }
        public int employeeId { get; set; }
        public string companyName { get; set; }
        public int companyId { get; set; }
        public Designation designation { get; set; }
        public Department department { get; set; }
        public enum Designation
        {
            HardearEngineer,
            Webdeveloper,
            Softwareengineer,
            Businessanalyst,
            Systemsanalyst,
            Technicalsupport
        };
        public enum Department
        {
            AccountsandFinance,
            HR,
            Salesandmarketing,
            Infrastructures,
            Researchanddevelopment,
            IT
        };
    }
}