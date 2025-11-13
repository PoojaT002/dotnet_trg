using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 10, 20, 30, 40, 50 };
            foreach(int item in myArray)
            {
                Console.Write(item + "\t");

            }
            Console.WriteLine("\nAfter reversed my Array is: ");
            Array.Reverse(myArray);
            foreach(int item in myArray)
            {
                Console.Write(item + "\t");
            }
            Console.ReadLine();
        }
    }
}
