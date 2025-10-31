using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password: ");
            string password= Console.ReadLine();

            int length = password.Length;

            string strenght;

            if (length < 6)
                strenght = "weak";

            else if (length <= 10)

                strenght = "Medium";

            else
                strenght = "Strong";

            Console.WriteLine($"\nPassword strength: {strenght}");
           

        }
    }
}
