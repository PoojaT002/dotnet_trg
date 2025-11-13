using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowSize, colSize;
            Console.WriteLine("Enter the number of rows (or) Students");
            rowSize = Convert.ToInt32(Console.ReadLine());
            colSize = 5; //fixed no of subjects
            int[,] studentMarks = new int[rowSize, colSize];
            for (int i = 0; i < rowSize; i++)
            {
                Console.WriteLine($"Enter the marks for student {i + 1}");
                for (int j = 0; j < colSize; j++)
                {
                    Console.WriteLine($"Enter the marks for subject {j + 1}");
                    studentMarks[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Displaying the marks of student");
            for (int i = 0; i < rowSize; i++)
            {
                Console.WriteLine("\nStudent 1 marks are \n");
                for (int j = 0; j < colSize; j++)
                {
                    Console.WriteLine(studentMarks[i, j] + "\t");
                }
            }
              
               Console.WriteLine("\ncalculation of Student 1 marks are \n");
                for (int i = 0; i < rowSize; i++)
                {
                    int total = 0;
                    for (int j = 0; j < colSize; j++)
                    {
                        total += studentMarks[i, j];
                    }
                    Console.WriteLine($"Total marks of student {i + 1}={total}");

                }
            Console.ReadLine();
        }
            
        }
    }


