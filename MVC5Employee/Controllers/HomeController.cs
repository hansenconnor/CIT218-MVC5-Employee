using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Employee.Models;

namespace MVC5Employee.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmp(int empID, string empName, int empSal)
        {
            Employee e = new Employee()
            {
                Id = empID,
                Name = empName,
                Salary = empSal
            };
            return View("EmpConfirm", e);
        }
        public ActionResult AddEmp()
        {
            return View("NewEmpForm");
        }

        public ActionResult GrossPayCalculator()
        {
            return View();
        }

        public ActionResult mainOfficeEmployees()
        {
            return View();
        }
    }
}