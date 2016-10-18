using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CECM.Web.Models
{
    public class EmployeeInitializer : DropCreateDatabaseAlways<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee {EmployeeID = 1, FirstName = "Rebin", LastName = "Varghese", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Thiruvalla", Region = "My", PostalCode = "689581", Country = "IN", HomePhone = "9497273935" },
                new Employee {EmployeeID = 2, FirstName = "Joe", LastName = "Davis", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8569369854" },
                new Employee {EmployeeID = 3, FirstName = "Dino", LastName = "Sunny", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 4, FirstName = "Catherine", LastName = "K", Title = "Ms.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 5, FirstName = "Angitha", LastName = "Das", Title = "Ms.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:01:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 6, FirstName = "Akshay", LastName = "Venugopal", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9497273935" },
                new Employee {EmployeeID = 7, FirstName = "Noyal", LastName = "P", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 8, FirstName = "Akhila", LastName = "Antony", Title = "Ms.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 9, FirstName = "Kiran", LastName = "Francis ", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 10, FirstName = "Sujith", LastName = "K", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 11, FirstName = "Vineeth", LastName = "E", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 12, FirstName = "Aswati", LastName = "S", Title = "Ms.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 13, FirstName = "Jidesh", LastName = "P", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 14, FirstName = "Dilip", LastName = "Geevarghese", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 15, FirstName = "Jithu", LastName = "P", Title = "Mr.",BirthDate = Convert.ToDateTime("1-1-1993 12:00:00 AM") ,HireDate = Convert.ToDateTime("7-18-2016 12:00:00 AM"),Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" }
            };

            //var employees = new List<Employee>
            //{
            //    new Employee {FirstName = "Rebin", LastName = "Varghese"},
            //    new Employee {FirstName = "Joe", LastName = "Davis"}
            //};

            foreach (var temp in employees)
            {
                context.Employees.Add(temp);
            }
            context.SaveChanges();
        }
    }
}