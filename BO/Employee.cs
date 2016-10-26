namespace BO
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }
        public System.Nullable<System.DateTime> BirthDate { get; set; }

        public System.Nullable<System.DateTime> HireDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }

        //public string Extension { get; set; }

        //public System.Data.Linq.Binary Photo { get; set; }

        //public string Notes { get; set; }

        //public System.Nullable<int> ReportsTo { get; set; }

        //public string PhotoPath { get; set; }
        public string HomePhone
        {
            get; set;
        }
    }
}