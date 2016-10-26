using BO;
using CECM.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace CECM.Web.Controllers
{
    public class HomeController : Controller
    {
        //private EmployeeRepository _Employee;
        public ActionResult Index()
        {

            //return "This is Rebins";
            // List<string> _alphalist = new List<string>() { "ALL", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            //_Employee = new EmployeeRepository();
            //ViewBag.Employees = _Employee;

            // ViewBag.SubMenu = _alphalist.ToList();
            //string[] _alphalist = new string[] { "ALL", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Alphabets alphalist = new Alphabets();
            ViewBag.SubMenu = alphalist._alphalist;


            var employee = db.Employee.ToList();

            return View(employee);
       
            //return View(_Employee.Employees);
        }

        public ActionResult Search(string filter)
        {
            var listEmployees = Info_seed();
            var employees = listEmployees.Employees;

            ViewBag.Message = "Your application description page.";

            //var employees = new EmployeeRepository().Employees;

            Alphabets alphalist = new Alphabets();
            ViewBag.SubMenu = alphalist._alphalist;




            //if (filter != "ALL")
            //{
            //    return View("Index", employees.Where(x => x.FirstName.Contains(filter) || x.LastName.Contains(filter)));
            //}
            //else
            //{
            //    return View("Index", employees);
            //}


            var employee = db.Employee.ToList();

            if (filter != "ALL")
            {
                listEmployees.Employees = employees.Where(x => x.FirstName.Substring(0, 1).ToLower().Contains(filter.ToLower()) || x.LastName.Substring(0, 1).ToLower().Contains(filter.ToLower())).ToList();
                return View("Index", listEmployees);
                return View("Index", employee.Where(x => x.FirstName.Contains(filter) || x.LastName.Contains(filter)));
            }
            else
            {
                listEmployees.Employees = employees;
                return View("Index", listEmployees);
            }
        }
                return View("Index", employee);
            }


        public ActionResult SearchBox(string SearchWord)
        {
            var listEmployees = Info_seed();
            var employees = listEmployees.Employees;
            listEmployees.Employees = employees.Where(x => x.FirstName.ToLower().Contains(SearchWord.ToLower()) || x.LastName.ToLower().Contains(SearchWord.ToLower()) || x.Address.ToLower().Contains(SearchWord.ToLower())).ToList();
            return View("Index", listEmployees);

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
        public ListViewEmployee Info_seed()
        {
            var employees = new EmployeeRepository().Employees;
            ListViewEmployee listEmployees = new ListViewEmployee();
            AlphabetsRepository alphabetsRepo = new AlphabetsRepository();
            listEmployees.Alphabets = alphabetsRepo.listAlphabets;
            listEmployees.Employees = employees;

            return listEmployees;
        }

    }
}