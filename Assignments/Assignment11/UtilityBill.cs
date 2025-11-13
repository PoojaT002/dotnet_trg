using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class UtilityBill
    {
        public int CustomerID;
        public string CustomerName;

        public static decimal GetServiceCharge()
        {
            return 50m;
        }

        public int TotalUsage(params int[] readings)
        {
            int total = 0;
            foreach (int unit in readings)
                total += unit;
            return total;
        }

        public void CalculateBill(int totalUsage,out decimal total,out decimal tax, out decimal netPayable)
        {
            decimal ratePerUnit = 6.5m;
            total = totalUsage * ratePerUnit;
            tax = total * 0.10m;
            netPayable = total + tax + GetServiceCharge();
        }

        public void DisplayBill(decimal total, decimal tax, decimal net)
        {
            Console.WriteLine("\n======== Utility Bill ==========");
            Console.WriteLine($"Customer ID : {CustomerID}");
            Console.WriteLine($"Customer Name : {CustomerName}");
            Console.WriteLine($"Service Charge : {GetServiceCharge()}");
            Console.WriteLine($"Total Usage : {total:F2}");
            Console.WriteLine($"Tax Applied : {tax:F2}");
            Console.WriteLine($"Net Payable : {net:F2}");

            Console.WriteLine("\n===================================");
        }
    }
}
