using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    internal class FunWithoutRtnWithArgs
    {
        static void addition(int x, int y)
        {
            int res;
            res = x + y;
            Console.WriteLine("X+Y = " + res); 
        }
         static void Main()
        {
            addition(34, 89);
            int a, b;
            Console.WriteLine("Enter the value for a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            addition(a, b);
            Console.ReadLine();
        }
    }
}

