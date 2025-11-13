using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexes
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
    }
    internal class EmployeeListWIndex
    {
        List<Employee> employeelist = new List<Employee>()
        { new Employee() { EmployeeId = 1,EmployeeName = "Pooja",Gender="Female"},
        new Employee() { EmployeeId = 2,EmployeeName = "Rohit",Gender="male"}
        };

        public string this[int empid]
        {
            get
            {
                return employeelist.FirstOrDefault(e => e.EmployeeId == empid)?.EmployeeName;
            }
            set
            {
                employeelist.FirstOrDefault(e => e.EmployeeId == empid).EmployeeName = value;
            }
        }
        
        
    }
}
