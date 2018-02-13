using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJan2018.Models
{
    public class EmployeeDeptVM
    {
        public EmployeeVM Employee { get; set; }
        public DepartmentVM Department { get; set; }
    }
}