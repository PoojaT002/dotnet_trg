using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_ClassDemo
{
    static class MathHelper
    {
        public static double pi = 3.14159;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");
            return (double)a / (double)b;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int result=MathHelper.Add(10, 5);
            Console.WriteLine("Addition: " + result);
            result = MathHelper.Subtract(10, 5);
            Console.WriteLine("Subtraction: " + result);
            result = MathHelper.Multiply(10, 5);
            Console.WriteLine("Multiplication: " + result);
            double result1 = MathHelper.Divide(10, 5);
            Console.WriteLine("Divison: " + result1);
            Console.ReadLine();

        }
         
    }
}
