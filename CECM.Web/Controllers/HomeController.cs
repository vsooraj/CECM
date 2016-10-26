using BO;
using CECM.Web.Models;
using CECM.Web.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace CECM.Web.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext db;
        HomeViewModel _homeViewModel = new HomeViewModel();
        AlphabetsRepository _alphabetsRepository = new AlphabetsRepository();
        public HomeController()
        {
            db = new EmployeeContext();
        }
        public ActionResult Index()
        {
            //var employee = db.Employees.ToList();
            //return View(employee);
            var homeView = GetHomeView("");
            return View("Index", homeView);
        }
        public ActionResult Search(string filter)
        {
            _homeViewModel.Alphabets = _alphabetsRepository.listAlphabets;
            ViewBag.Message = "Your application description page.";

            if (filter == "ALL")
            {
                return View("Index", db.Employees.ToList());
            }
            else
            {
                _homeViewModel.Employees = db.Employees.Where(x => x.FirstName.Substring(0, 1).ToLower().Contains(filter.ToLower()) ||
               x.LastName.Substring(0, 1).ToLower().Contains(filter.ToLower())).ToList();
                return View("Index", _homeViewModel);

            }

        }

        public ActionResult SearchBox(string SearchWord)
        {
            var homeView = GetHomeView(SearchWord);
            return View("Index", homeView);

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
        public HomeViewModel GetHomeView(string filter)
        {
            _homeViewModel.Alphabets = _alphabetsRepository.listAlphabets;
            if (!string.IsNullOrEmpty(filter))
            {
                _homeViewModel.Employees = db.Employees.Where(x => x.FirstName.ToLower().Contains(filter.ToLower()) ||
                                    x.LastName.ToLower().Contains(filter.ToLower()) ||
                                    x.Address.ToLower().Contains(filter.ToLower())).ToList();
            }
            else
            {
                _homeViewModel.Employees = db.Employees.ToList();

            }

            return _homeViewModel;
        }

    }
}
