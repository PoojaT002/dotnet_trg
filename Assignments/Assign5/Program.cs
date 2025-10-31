using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter bill amount: ");
            double billAmt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter total people: ");
            int people = Convert.ToInt32(Console.ReadLine());

            double totalAmt;

            if(billAmt>1000)
            {
                double gst = billAmt * 0.05;
                double serviceChrg = billAmt * 0.10;
                totalAmt = billAmt + gst + serviceChrg;
            }
            else
            {
                totalAmt = billAmt;
            }
            double AmtPerPerson = totalAmt / people;
            Console.WriteLine($"\nEach person should pay: Rs{AmtPerPerson}");
        }
    }
}
