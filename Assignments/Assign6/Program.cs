using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter show time (24-hrs format): ");
            int showTime = Convert.ToInt32(Console.ReadLine());

            int ticketPrice;
            if(age<12)
            {
                ticketPrice = 150;
            }
            else
            {
                if (showTime < 18)
                    ticketPrice = 250;
                else
                    ticketPrice = 300;
            }
            Console.WriteLine($"Ticket price: Rs{ticketPrice}");
        }
    }
}
