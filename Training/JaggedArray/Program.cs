using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare array of 4 elements
            int[][] jaggedArray = new int[4][];

            //initialize the elements
            jaggedArray[0] = new int[2] { 7,9 };
            jaggedArray[1] = new int[4] { 7,9,12,42};
            jaggedArray[2] = new int[6] { 3,5,7,9,11,13 };
            jaggedArray[3] = new int[3] { 4,6,8};

            //display the array elements:
            for(int i=0; i<jaggedArray.Length; i++)
            {
                System.Console.Write("Elements({0}):", i + 1);

                for(int j=0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write(jaggedArray[i][j] + " \t ");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
