using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    internal class CallByValueRefDemo
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10; b = 20;
            Console.WriteLine("\nCalling by value demo");
            Console.WriteLine("Value of A before calling MethodValue " + a);
            MethodValue(a);
            Console.WriteLine("After calling MethodValue A value " + a);

            Console.WriteLine("\nCalling by Reference demo");
            Console.WriteLine("Value of B before calling MethodRef " + b);
            MethodRef(ref b);
            Console.WriteLine("After calling MethodRef B value " + b);
        }

        static void MethodValue(int a)
        {
            a = a + 10;
            Console.WriteLine("Value of A in MethodValue " + a);
        }
        static void MethodRef(ref int b)
        {
            b = b + 10;
            Console.WriteLine("Value of B in MethodRef " + b);
        }
        
    }
}
