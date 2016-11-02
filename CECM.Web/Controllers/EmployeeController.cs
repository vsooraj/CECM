using BO;
using CECM.Web.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

//using System.Collections.Generic;


namespace CECM.Web.Controllers
{
    public class EmployeeController : Controller
    {




        //[HttpPost]
        //public JsonResult Index(string Prefix)
        //{
        //    //Note : you can bind same list from database  
        //    //List<Country> ObjList = new List<Country>()
        //    //{
        //    //        new Country {Id=1,Name="Latur" },
        //    //        new Country {Id=2,Name="Mumbai" },
        //    //        new Country {Id=3,Name="Pune" },
        //    //        new Country {Id=4,Name="Delhi" },
        //    //        new Country {Id=5,Name="Dehradun" },
        //    //        new Country {Id=6,Name="Noida" },
        //    //        new Country {Id=7,Name="New Delhi" }
        //    //};

        //    ////var employee = db.Employees.ToList();


        //    ////Searching records from list using LINQ query  
        //    //var Country = (from N in ObjList
        //    //               where N.Name.StartsWith(Prefix)
        //    //               select new { N.Name });
        //    //return Json(Country, JsonRequestBehavior.AllowGet);
        //}






        private EmployeeContext db = new EmployeeContext();

        // GET: Employees
        public ActionResult Index()
        {
            var employee = db.Employees.ToList();

            return View(employee);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,FirstName,LastName,Title,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,FirstName,LastName,Title,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}