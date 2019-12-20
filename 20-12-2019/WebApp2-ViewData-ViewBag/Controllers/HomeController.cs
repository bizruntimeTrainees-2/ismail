using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
       
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
        
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewBag.Employee= model;
            ViewBag.PageTitle = "Employee Details";

            return View();// it looks for view fie with same name as action method
            
        }

    }
}
