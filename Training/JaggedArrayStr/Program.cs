using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare array of 4 elements
            string[][] Members = new string[4][] {
           new string[] { "Rocky", "Sam", "Alex" },
            new string[] { "Hina", "Mona", "Preeta", "Seeta" },
            new string[] { "Rocky", "Reeta", "Dina","Teena","Jeta" },
            new string[] { "Rocky", "Sam", },
            };

            //display the array elements:
            for (int i = 0; i < Members.Length; i++)
            {
                System.Console.Write("Name List({0}): ", i + 1);

                for (int j = 0; j < Members[i].Length; j++)
                {
                    System.Console.Write(Members[i][j] + " \t ");
                }
                System.Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
