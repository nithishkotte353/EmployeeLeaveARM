using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeLeaveArm.Models
{
    public class EmployeeLeave
    {
       public string EmployeeNumber { get; set; }
       public string EmployeeName { get; set; }
       public int Days { get; set; }
       public string Reason { get; set; }
    }
}