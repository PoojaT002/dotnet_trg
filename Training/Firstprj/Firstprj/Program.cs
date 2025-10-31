using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstprj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            float avg_score = 67.45f;
            double precise_value = 12345.678;
            decimal money_amount = 1233.12m;
            char grade = 'A';
            string message = "Hello welcome to the session";
            Console.WriteLine($"Num1 value is {num1} \nNum2 value is {num2}");
            Console.WriteLine($"average_score = {avg_score} \nprecise_value = {precise_value} \nmoney ={money_amount} " +
                 $"\nGrade ={grade} \nMessage ={message}");
            Console.ReadLine();

        }
    }
}