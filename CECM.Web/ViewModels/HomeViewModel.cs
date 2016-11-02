using BO;
using PagedList;
using System.Collections.Generic;

namespace CECM.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Employee> Employees { get; set; }

        public IPagedList<Employee> page_Employees { get; set; }

        public List<Alphabets> Alphabets { get; set; }
    }
}