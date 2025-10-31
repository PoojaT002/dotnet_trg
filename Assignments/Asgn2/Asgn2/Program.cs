using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asgn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            string grade;
            if (marks >= 90)

                grade = "A+";

            else if (marks >= 80)

                grade = "A";

            else if (marks >= 70)

                grade = "B";


            else if (marks >= 60)

                grade = "C";

            else if (marks >= 50)
                grade = "D";
            else
                grade = "Fail";

            Console.WriteLine($"\nStudent Name: {name}");
            Console.WriteLine($"\nMarks: {marks}");
            Console.WriteLine($"Grade: {grade}");

        }
    }
}
