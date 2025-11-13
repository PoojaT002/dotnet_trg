using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Overloading overloading = new Overloading();
            overloading.GetEmployeeInfo(104);
            overloading.GetEmployeeInfo("Poo");
            overloading.GetEmployeeInfo(101, "Poo");
            overloading.GetEmployeeInfo("Poo", 102);

        }
    }
}
