using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    internal class Static_NonStatic_FunDemo
    {
        static int x;
        int y;
        void NonStaticMethod()
        {
            Console.Write("Non static Function");
        }
        static void StaticMethod()
        {
            Console.WriteLine("Static Function");
        }
        static void Main(string[] args)
        {
            x = 900;
            Static_NonStatic_FunDemo staticNSObj = new Static_NonStatic_FunDemo();
            staticNSObj.y = 200;

            Console.WriteLine("Static variable accessing without object " + x);
            Console.WriteLine("Non static variable accessing through object " + staticNSObj.y);
            StaticMethod();
            staticNSObj.NonStaticMethod();
            Console.ReadLine();
        }
    }
}
