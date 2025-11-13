using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter purchase amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double discountprcnt=0;

            if (amount < 1000)

                discountprcnt = 0;


            else if (amount <= 5000)

                discountprcnt = 0.10;

            else
                discountprcnt = 0.20;

            double discountAmt = amount + discountprcnt;
            double finalAmt = amount - discountprcnt;

            Console.WriteLine($"\nDiscount Applied: {discountprcnt + 100}%");
            Console.WriteLine($"\nFinal Amount: {finalAmt}");
          

        }
    }
}
