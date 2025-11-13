using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of items: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Item[] items = new Item[n];
            double grandTotal = 0;

            for(int i=0; i<n; i++)
            {
                items[i] = new Item();

                Console.WriteLine($"\nItem {i + 1}:");

                Console.Write("Enter item name: ");
                items[i].Name = Console.ReadLine();

                Console.Write("Enter quantity: ");
                items[i].Quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price per unit: ");
                items[i].PricePerPercent = Convert.ToDouble(Console.ReadLine());

                double total = items[i].GetTotal();
                grandTotal += total;

                Console.WriteLine($"{items[i].Name} total= Rs {total}");

            }

            double discountRate = 0;
            if (grandTotal > 5000)
                discountRate = 0.20;
            else if (grandTotal >= 2000)
                discountRate = 0.10;
            else if (grandTotal >= 1000)
                discountRate = 0.05;

            double discountAmt = grandTotal * discountRate;
            double finalBill = grandTotal - discountAmt;

            Console.WriteLine("\n----Bill Summary-----");
            foreach(var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Quantity} * {item.PricePerPercent}= Rs {item.GetTotal()}");
            }

            Console.WriteLine($"\nTotal Amount: Rs {grandTotal}");
            Console.WriteLine($"\nDiscount: Rs {discountAmt}");
            Console.WriteLine($"\nFinal Bill: Rs {finalBill}");
        }
    }
}




