using CECM.Web.Models;
using CECM.Web.ViewModels;
using PagedList;
using System;
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
        public ActionResult Index(string filter, int? page, string SearchWord, string sortOrder)
        {
            HomeViewModel homeView;

            ViewBag.SearchWord = SearchWord;
            ViewBag.filter = filter;
            //Home View
            if (string.IsNullOrEmpty(SearchWord) == true && string.IsNullOrEmpty(filter) == true)
            {
                homeView = GetHomeView("");

                homeView.page_Employees = homeView.Employees.ToPagedList(page ?? 1, 10);

            }
            //Search by Search Word
            else if (string.IsNullOrEmpty(SearchWord) == false)
            {
                homeView = GetHomeView(SearchWord);
                homeView.page_Employees = homeView.Employees.ToPagedList(page ?? 1, 3);
            }

            //Search by Alphabet
            else
            {
                homeView = GetHomeView("");

                ViewBag.Message = "Your application description page.";

                if (filter == "ALL")
                {
                    homeView.page_Employees = homeView.Employees.ToPagedList(page ?? 1, 3);
                }
                else
                {
                    homeView.Employees = db.Employees.Where(x => x.FirstName.Substring(0, 1).ToLower().Contains(filter.ToLower()) ||
                   x.LastName.Substring(0, 1).ToLower().Contains(filter.ToLower())).ToList();
                    homeView.page_Employees = homeView.Employees.ToPagedList(page ?? 1, 3);

                }
            }
            //Sorting

            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            var sortView = homeView;

            switch (sortOrder)
            {
                case "name_desc":
                    sortView.Employees = sortView.Employees.OrderByDescending(s => s.LastName).ToList();
                    break;
                case "Date":
                    sortView.Employees = sortView.Employees.OrderBy(s => s.HireDate).ToList();
                    break;
                case "date_desc":
                    sortView.Employees = sortView.Employees.OrderByDescending(s => s.HireDate).ToList();
                    break;
                default:  // Name ascending 
                    sortView.Employees = sortView.Employees.OrderBy(s => s.LastName).ToList();
                    break;
            }
            sortView.page_Employees = sortView.Employees.ToPagedList(page ?? 1, 10);
            return View("Index", sortView);


        }
        public ActionResult Search(string filter, int? page)
        {
            _homeViewModel.Alphabets = _alphabetsRepository.listAlphabets;
            ViewBag.Message = "Your application description page.";

            if (filter == "ALL")
            {
                _homeViewModel.Employees = db.Employees.ToList();
                _homeViewModel.page_Employees = _homeViewModel.Employees.ToPagedList(page ?? 1, 3);
                return View("Index", _homeViewModel);
            }
            else
            {
                _homeViewModel.Employees = db.Employees.Where(x => x.FirstName.Substring(0, 1).ToLower().Contains(filter.ToLower()) ||
               x.LastName.Substring(0, 1).ToLower().Contains(filter.ToLower())).ToList();
                _homeViewModel.page_Employees = _homeViewModel.Employees.ToPagedList(page ?? 1, 3);
                return View("Index", _homeViewModel);
            }
        }

        public ActionResult SearchBox(string SearchWord, int? page)
        {
            var homeView = GetHomeView(SearchWord);
            _homeViewModel.page_Employees = _homeViewModel.Employees.ToPagedList(page ?? 1, 3);
            return View("Index", homeView);
        }

        public ViewResult Sort(string sortOrder, string attr, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            var sortView = GetHomeView("");

            switch (sortOrder)
            {
                case "name_desc":
                    sortView.Employees = sortView.Employees.OrderByDescending(s => s.LastName).ToList();
                    break;
                case "Date":
                    sortView.Employees = sortView.Employees.OrderBy(s => s.HireDate).ToList();
                    break;
                case "date_desc":
                    sortView.Employees = sortView.Employees.OrderByDescending(s => s.HireDate).ToList();
                    break;
                default:  // Name ascending 
                    sortView.Employees = sortView.Employees.OrderBy(s => s.LastName).ToList();
                    break;
            }
            sortView.page_Employees = sortView.Employees.ToPagedList(page ?? 1, 3);
            return View("Index", sortView);
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
