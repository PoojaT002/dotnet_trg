using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    internal class FunWithoutRtnWithoutArgs
    {
        static void addition()
        {
            int x, y, res;
            Console.WriteLine(" Enter the value for x and y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            res = x + y;
            Console.WriteLine(" X+ y = " + res);
        }
        static void Main()
        {
            addition();

        }
    }
}
