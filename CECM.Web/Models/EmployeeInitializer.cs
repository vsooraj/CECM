using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CECM.Web.Models
{
    public class EmployeeInitializer : DropCreateDatabaseAlways<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee {EmployeeID = 1, FirstName = "Rebin", LastName = "Varghese", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Thiruvalla", Region = "My", PostalCode = "689581", Country = "IN", HomePhone = "9497273935" },
                new Employee {EmployeeID = 2, FirstName = "Joe", LastName = "Davis", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8569369854" },
                new Employee {EmployeeID = 3, FirstName = "Dino", LastName = "Sunny", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 4, FirstName = "Catherine", LastName = "K", Title = "Ms.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 5, FirstName = "Angitha", LastName = "Das", Title = "Ms.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 6, FirstName = "Akshay", LastName = "Venugopal", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9497273935" },
                new Employee {EmployeeID = 7, FirstName = "Noyal", LastName = "P", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 8, FirstName = "Akhila", LastName = "Antony", Title = "Ms.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 9, FirstName = "Kiran", LastName = "Francis ", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 10, FirstName = "Sujith", LastName = "K", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 11, FirstName = "Vineeth", LastName = "E", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 12, FirstName = "Aswati", LastName = "S", Title = "Ms.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 13, FirstName = "Jidesh", LastName = "P", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 14, FirstName = "Dilip", LastName = "Geevarghese", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 15, FirstName = "Jithu", LastName = "P", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" }
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