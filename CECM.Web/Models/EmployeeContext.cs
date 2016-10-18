using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CECM.Web.Models
{
    public class EmployeeContext : DbContext
    {
        // Enables CRUD functionality
        public DbSet<Employee> Employees { get; set; }
    }
}