using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexes
{
    class StudentMarks
    {
        private int[] marks = new int[5];
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("Invalid Index! Returning -1");
                    return -1;
                }
                return marks[index];
            }
            set
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("Invalid Index! Cannot set value.");
                }
                else
                {
                    marks[index] = value;
                }
            }
        }

        public void DisplayMarks()
        {
            Console.WriteLine("Marks of Student");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {marks[i]}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //    StudentMarks studentMarks = new StudentMarks();
            //studentMarks[0] = 85;
            //    studentMarks[1] = 90;
            //    studentMarks[2] = 75;
            //    studentMarks[3] = 80;
            //    studentMarks[4] = 95;
            //    studentMarks.DisplayMarks();

            EmployeeListWIndex employee = new EmployeeListWIndex();
            Console.WriteLine($" employee[0] : {employee[1]}");

            Console.ReadLine();
        }
    }
}
