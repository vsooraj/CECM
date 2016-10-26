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
            var listEmployees = Info_seed();
            return View(listEmployees);
        }
        public ActionResult Search(string filter)
        {
            var listEmployees = Info_seed();
            var employees = listEmployees.Employees;

            if (filter != "ALL")
            {
                listEmployees.Employees = employees.Where(x => x.FirstName.Substring(0, 1).ToLower().Contains(filter.ToLower()) || x.LastName.Substring(0, 1).ToLower().Contains(filter.ToLower())).ToList();
                return View("Index", listEmployees);
            }
            else
            {
                listEmployees.Employees = employees;
                return View("Index", listEmployees);
            }
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