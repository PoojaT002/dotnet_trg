using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Welcome to online Utility Billing System ===============");
            Console.Write("Enter number of Customers: ");
            int n= Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                UtilityBill bill = new UtilityBill();

                Console.WriteLine($"\nEnter details for Customer #{i}");
                Console.Write("Customer ID: ");
                bill.CustomerID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Customer Name: ");
                bill.CustomerName = Console.ReadLine();

                Console.Write("Enter monthly usage reading : ");
                string[] input = Console.ReadLine().Split(' ');
                int[] readings = Array.ConvertAll(input, int.Parse);

                int totalUsage = bill.TotalUsage(readings);
                bill.CalculateBill(totalUsage, out decimal total, out decimal tax, out decimal net);
                bill.DisplayBill(total, tax, net);
            }
            
            Console.WriteLine("========== Thankyou for using Utility billing System ===========");
            Console.ReadLine();
        }
    }
}
