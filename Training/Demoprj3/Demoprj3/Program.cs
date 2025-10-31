using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoprj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Choose the option****** \n 1.Add \n 2.Subtract \n 3.Multiply \n 4.Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            double num1, num2;
            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition is: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction is: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is: " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division is: " + (num1 / num2));
                    break;
            }
        }
    }
}
