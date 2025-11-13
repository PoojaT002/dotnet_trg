using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Department
    {
        int deptId;
        string deptName;
        string deptLocation;
        
        static Department()
        {
            Console.WriteLine("Static Constructor");
        }
        public Department()
        {
            deptId = 101;
            deptName = "IT";
            deptLocation = "Bangalore";
            Console.WriteLine("Default or Parameterless Constructor called");
        }
        public Department(int deptId, string deptName, string deptLocation)
        {
            Console.WriteLine("Parameterised Construuctor called");
            this.deptId = deptId;
            this.deptName = deptName;
            this.deptLocation = deptLocation;

        }
        public Department(Department dept)
        {
            Console.WriteLine("copy Constructor called");
            this.deptId = 104;
            this.deptName = "HR";
            this.deptLocation = dept.deptLocation;
        }
        public void getDepartmentInfo()
        {
            Console.Write("Enter department Id: ");
            deptId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter department Name: ");
            deptName=(Console.ReadLine());
            Console.Write("Enter department Location: ");
            deptLocation =(Console.ReadLine());
        }

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine("\nDepartment Details: ");
            Console.WriteLine("Department Id: " + deptId);
            Console.WriteLine("Department Name: " + deptName);
            Console.WriteLine("Department Location: " + deptLocation);
        }
         
    }
}
