using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails employee = new EmployeeDetails();
            int empId;
            string empName;
            string empDesignation;
            Console.WriteLine("Enter the EmployeeId,Name,Designation");
            empId = Convert.ToInt32(Console.ReadLine());
            empName = Console.ReadLine();
            empDesignation = Console.ReadLine();

            employee.AcceptEmployeeDetails(empId, empName, empDesignation);
            employee.DisplayEmployeeDetails();

            Console.ReadLine();
            //employee.AcceptEmployeeDetails(101,"Pooja","SE");
            //employee.DisplayEmployeeDetails();

        }
    }
}
