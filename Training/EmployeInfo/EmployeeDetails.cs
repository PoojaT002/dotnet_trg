using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeInfo
{
    internal class EmployeeDetails
    {
        private int empId;
        private string empName;
        private string empDesignation;

        public void AcceptEmployeeDetails(int id,string empName,string empDesignation="Jr.Associate")
        {
            this.empId = id;
            this.empName = empName;
            this.empDesignation = empDesignation;
            //Console.WriteLine("Enter the employeeId,NAme,Desig");

            //empId = Convert.ToInt32(Console.ReadLine());
            //empName = Console.ReadLine();
            //empDesignation = Console.ReadLine();

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Designation: " + empDesignation);
        }
    }
}
