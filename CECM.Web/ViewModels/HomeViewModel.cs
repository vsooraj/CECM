using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CECM.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Employee> Employees { get; set; }

        public List<Alphabets> Alphabets { get; set; }
    }
}