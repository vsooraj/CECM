namespace BO
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayName("First Name")]
        [RegularExpression("([A-Za-z.',-]+)", ErrorMessage = "The name can contain only alphabets and special characters .,-'")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [RegularExpression("([A-Za-z.',-]+)", ErrorMessage = "The name can contain only alphabets and special characters .,-'")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Birth Date")]
        //[RegularExpression("[0-12/0-31/1753-9999]")]
        public System.Nullable<System.DateTime> BirthDate { get; set; }

        [Required]
        [DisplayName("Hire Date")]
        public System.Nullable<System.DateTime> HireDate { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        public string Region { get; set; }

        [DisplayName("Postal Code")]
        [RegularExpression("([0-9]+)")]
        public string PostalCode { get; set; }

        public string Country { get; set; }

        [Required]
        [DisplayName("Home Phone")]
        //[Range(0, 9)]
        [RegularExpression("([+]*[0-9]+)")]
        public string HomePhone { get; set; }

        //public string Extension { get; set; }

        //public System.Data.Linq.Binary Photo { get; set; }

        //public string Notes { get; set; }

        //public System.Nullable<int> ReportsTo { get; set; }

        //public string PhotoPath { get; set; }

    }
}