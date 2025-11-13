using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Student
    {
        public int id;
        public string name;
        public int[] subjectMarks = new int[3];
        public int total;
        public double avg;
        public string grade;

        public void CalculateResult()
        {
            total = 0;
            for(int i=0; i<subjectMarks.Length; i++)
            {
                total += subjectMarks[i];
            }
            avg = total / 3.0;

            if (avg >= 90)
                grade = "A+";
            else if (avg >= 80)
                grade = "A";
            else if (avg >= 70)
                grade = "B";
            else if (avg >= 60)
                grade = "C";
            else
                grade = "D";
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n----Student Report----");
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Grade: " + grade);
        }
    }
}
