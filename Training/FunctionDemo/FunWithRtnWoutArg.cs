using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    internal class FunWithRtnWoutArg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function with Return Without Args\n");
            //Console.WriteLine("Addition Result" + Addition());
            int result = Addition();
            Console.WriteLine("Addition Result: " + result);

        }
        static int Addition()
        {
            int num1, num2, sum;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            return sum;
        }
        
        }

    }

