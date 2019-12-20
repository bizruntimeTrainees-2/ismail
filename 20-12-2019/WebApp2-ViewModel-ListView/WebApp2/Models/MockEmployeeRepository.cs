using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1, Name="Ramesh",Department="HR",Email="ramesh@gmail.com"},
                new Employee(){ Id=2, Name="Raju",Department="IT",Email="raju@gmail.com"},
                new Employee(){ Id=3, Name="Mahesh",Department="IT",Email="mahesg@gmail.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
