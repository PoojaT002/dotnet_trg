using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolidDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeBase emp1=new PermanentEmployee();
            EmployeeBase emp2=new ContractEmployee();

            Console.WriteLine(emp1.GetBonus(10000));
            Console.WriteLine(emp2.GetBonus(10000));
        }
    }
}
