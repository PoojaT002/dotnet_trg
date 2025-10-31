using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter light color: ");
            string color = Console.ReadLine();

            string action;

            if (color == "red")
                action = "Stop";
            else if (color == "yellow")
                action = "Get ready";
            else if (color == "green")
                action = "Go";
            else
                action = "Invalid color! Please enter Red,Yellow,Green,";
            Console.WriteLine($"Action: {action}");
        }
    }
}
