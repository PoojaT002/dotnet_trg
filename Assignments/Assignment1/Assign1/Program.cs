using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your current salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your years of service: ");
            int year = Convert.ToInt32(Console.ReadLine());

            double bonusPerct;
            if(year>10)
            {
                bonusPerct = 0.20;
            }
            else if(year>=5 && year<=10)
            {
                bonusPerct = 0.10;
            }
            else
            {
                bonusPerct = 0.05;
            }
            double bonusAmt = salary * bonusPerct;
            double finalSal = salary + bonusAmt;

            Console.WriteLine($"\nBonus Percentage: {bonusPerct * 100}%");
            Console.WriteLine($"\nBonus Amounte: {bonusAmt}");
            Console.WriteLine($"Final salary after bonus: {finalSal}");

        }
    }
}
