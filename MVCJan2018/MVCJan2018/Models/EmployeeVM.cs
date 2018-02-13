using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJan2018.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DepartmentVM Department { get; set; }
    }
}