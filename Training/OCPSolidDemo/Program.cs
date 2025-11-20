using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolidDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            DiscountService service = new DiscountService();

            Console.WriteLine(service.ApplyDiscount(new VIPDiscount()));
            Console.WriteLine(service.ApplyDiscount(new EmployeeDiscount()));
        }
    }
}
