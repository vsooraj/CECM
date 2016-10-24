using BO;
using CECM.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace CECM.Web.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeRepository _Employee;
        public ActionResult Index()
        {

            //return "This is Rebins";
            // List<string> _alphalist = new List<string>() { "ALL", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            _Employee = new EmployeeRepository();
            ViewBag.Employees = _Employee;
            // ViewBag.SubMenu = _alphalist.ToList();
            //string[] _alphalist = new string[] { "ALL", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Alphabets alphalist = new Alphabets();
            ViewBag.SubMenu = alphalist._alphalist;
            return View(_Employee.Employees);
        }
        public ActionResult Search(string filter)
        {

            ViewBag.Message = "Your application description page.";
            var employees = new EmployeeRepository().Employees;
            Alphabets alphalist = new Alphabets();
            ViewBag.SubMenu = alphalist._alphalist;
            if (filter != "ALL")
            {
                return View("Index", employees.Where(x => x.FirstName.Contains(filter) || x.LastName.Contains(filter)));
            }
            else
            {
                return View("Index", employees);
            }

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