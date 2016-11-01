using BO;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CECM.Web.Models
{
    public class EmployeeContext : DbContext
    {
        // Enables CRUD functionality
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}