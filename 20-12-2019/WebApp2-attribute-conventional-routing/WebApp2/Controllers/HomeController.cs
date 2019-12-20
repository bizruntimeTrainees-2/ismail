using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp2.ViewModels;

namespace WebApp2.Controllers
{
   // [Route("Home")]
   [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [Route("~/Home")]
       // [Route("Home")]
       // [Route("Index")]
       //[Route("[action")]
        [Route("~/")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        //[Route("Details/{id?}")]
        // [Route("[action]/{id?}")]
         [Route("{id?}")]


        public ViewResult Details(int? id )
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
           
            return View(homeDetailsViewModel);// it looks for view fie with same name as action method
            
        }

    }
}
