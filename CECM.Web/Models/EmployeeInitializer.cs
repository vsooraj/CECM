using BO;
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
                new Employee {EmployeeID = 1, Title = "Mr.", FirstName = "Rebin", LastName = "Varghese", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Thiruvalla", Region = "My", PostalCode = "689581", Country = "IN", HomePhone = "9497273935" },
                new Employee {EmployeeID = 2, Title = "Mr.", FirstName = "Joe", LastName = "Davis", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8569369854" },
                new Employee {EmployeeID = 3, Title = "Mr.", FirstName = "Dino", LastName = "Sunny", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 4, Title = "Ms.", FirstName = "Catherine", LastName = "K", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 5, Title = "Ms.", FirstName = "Angitha", LastName = "Das", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 6, Title = "Mr.", FirstName = "Akshay", LastName = "Venugopal", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9497273935" },
                new Employee {EmployeeID = 7, Title = "Mr.", FirstName = "Noyal", LastName = "P", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 8, Title = "Ms.", FirstName = "Akhila", LastName = "A", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 9, Title = "Mr.", FirstName = "Kiran", LastName = "Francis ", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 10, Title = "Mr.", FirstName = "Sujith", LastName = "K", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 11, Title = "Mr.", FirstName = "Vineeth", LastName = "E", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 12, Title = "Ms.", FirstName = "Aswati", LastName = "S", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 13, Title = "Mr.", FirstName = "Jidesh", LastName = "P", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 14, Title = "Mr.", FirstName = "Dilip", LastName = "Geevarghese", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 15, Title = "Mr.", FirstName = "Jithu", LastName = "P", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 1, Title = "Mr.", FirstName = "A", LastName = "Varghese", BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Thiruvalla", Region = "My", PostalCode = "689581", Country = "IN", HomePhone = "9497273935" }
            };

            foreach (var temp in employees)
            {
                context.Employees.Add(temp);
            }
            context.SaveChanges();
        }
    }
}