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
        //public HomeController()
        //{
        //    _employeeRepository = new MockEmployeeRepository();  // tight coupling
        //}
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
        //public JsonResult Details()
        //{
        //    Employee model = _employeeRepository.GetEmployee(1);
        //    return Json(model);
        //}

        //to respect content negociation use Object result
        //public ObjectResult Details()
        //{
        //    Employee model = _employeeRepository.GetEmployee(1);
        //    return new ObjectResult(model);
        //}
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);

            return View();// it looks for view fie with same name as action method
            //relative path 
            //return View("test",model);
            //absolute path
           // return View("MyViews/Test.cshtml", model);

            
           // return View("../Test/Update");//it looks for a view file with your own custom name

           // return View("../../MyViews/Test");//it looks for view in two steps above from present view

        }

    }
}
