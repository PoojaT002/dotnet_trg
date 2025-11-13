using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department(201, "Hr", "Mumbai");
            department.DisplayDepartmentInfo();
            //department.getDepartmentInfo();

            Department dept1 = new Department();
            dept1.DisplayDepartmentInfo();

            Department dept2 = new Department(103,"Transport", "Delhi");
            dept2.DisplayDepartmentInfo();

            Department dept3 = new Department(dept2);
            dept3.DisplayDepartmentInfo();
            Console.ReadLine();
        }
    }
}
