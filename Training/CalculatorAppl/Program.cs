using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2;
            //Calculator calculator = new Calculator();
            //Console.Write("Enter first number: ");
            //num1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //num2=Convert.ToInt32(Console.ReadLine());
            //calculator.Addition(num1, num2);
            //calculator.Subtraction(num1, num2);
            Calculator calculator = new Calculator();
            calculator.Calculate(20, 10, out int addResult, out int difference, out int productResult, out int divisionResult);
            Console.WriteLine($"sum={addResult}\nDiff={divisionResult}\nproduct={productResult}\nDivision={divisionResult}");
            Console.ReadLine();
        }
    }
}
