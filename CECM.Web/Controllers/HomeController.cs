using CECM.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CECM.Web.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeRepository _Employee;
        public ActionResult Index()
        {

            //return "This is Rebins";
            ViewBag.Submenu = new List<string>() { "ALL", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            _Employee = new EmployeeRepository();
            ViewBag.Employees = _Employee;

            return View(_Employee.Employees);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}