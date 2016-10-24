using BO;
using System;
using System.Collections.Generic;

namespace CECM.Web.Models
{
    public class EmployeeRepository
    {
        public List<Employee> Employees;
        public EmployeeRepository()
        {
            Employees = new List<Employee>()
            //{
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") },
            //new Employee() { EmployeeID = 1, FirstName = "Noyal", LastName = "Vincy", Title = "Mr", Address = "Infopark", BirthDate = Convert.ToDateTime("1-1-2000"), HireDate = Convert.ToDateTime("10-10-2016") }
            //};
                        {
                new Employee {EmployeeID = 1, FirstName = "Rebin", LastName = "Varghese", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Thiruvalla", Region = "My", PostalCode = "689581", Country = "IN", HomePhone = "9497273935" },
                new Employee {EmployeeID = 2, FirstName = "Joe", LastName = "Davis", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8569369854" },
                new Employee {EmployeeID = 3, FirstName = "Dino", LastName = "Sunny", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 4, FirstName = "Catherine", LastName = "K", Title = "Ms.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 5, FirstName = "Angitha", LastName = "Das", Title = "Ms.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 6, FirstName = "Akshay", LastName = "Venugopal", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9497273935" },
                new Employee {EmployeeID = 7, FirstName = "Noyal", LastName = "P", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 8, FirstName = "Akhila", LastName = "A", Title = "Ms.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 9, FirstName = "Kiran", LastName = "Francis ", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 10, FirstName = "Sujith", LastName = "K", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 11, FirstName = "Vineeth", LastName = "E", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 12, FirstName = "Aswati", LastName = "S", Title = "Ms.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 13, FirstName = "Jidesh", LastName = "P", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 14, FirstName = "Dilip", LastName = "Geevarghese", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "9875635669" },
                new Employee {EmployeeID = 15, FirstName = "Jithu", LastName = "P", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Is", Region = "My", PostalCode = "658965", Country = "IN", HomePhone = "8586258565" },
                new Employee {EmployeeID = 1, FirstName = "A", LastName = "Varghese", Title = "Mr.",BirthDate = DateTime.Now ,HireDate = DateTime.Now,Address = "This", City = "Thiruvalla", Region = "My", PostalCode = "689581", Country = "IN", HomePhone = "9497273935" }
            };
        }
    }
}