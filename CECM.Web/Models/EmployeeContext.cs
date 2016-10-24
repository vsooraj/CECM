using BO;
using System.Data.Entity;

namespace CECM.Web.Models
{
    public class EmployeeContext : DbContext
    {
        // Enables CRUD functionality
        public DbSet<Employee> Employees { get; set; }
    }
}