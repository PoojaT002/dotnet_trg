using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Student Marks Evaluation----");
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[n];

            for(int i=0; i<n;i++)
            {
                students[i] = new Student();
                Console.WriteLine($"\nEnter details for Student  {i + 1}");
                Console.Write("Enter student Id: ");
                students[i].id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter student Name: ");
                students[i].name = Convert.ToString(Console.ReadLine());

                for(int j=0; j<3; j++)
                {
                    Console.Write($"\nEnter marks for subject {j + 1}: ");
                    students[i].subjectMarks[j] = Convert.ToInt32(Console.ReadLine());
                }
                students[i].CalculateResult();
            }
            foreach (Student s in students)
            {
                s.DisplayStudentDetails();
            }

            
        }
    }
}
