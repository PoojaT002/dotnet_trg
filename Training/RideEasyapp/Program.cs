using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Customer c = new Customer("Pooja", "9362523167", 120);
            Vehicle v = new Vehicle("Sedan", 200, 22);
            Ride ride = new Ride(new DateTime(2025, 11, 4), 15.8m, v);

            string[] addOns = { "priority-pickup", "fast-tag", "extra-luggage" };
            ride.ComputeBill(out decimal sub, out decimal gst, out decimal total, addOns);

            decimal beforeDiscount = total;
            Pricing.TryApplyCoupon_ByValue(total, 50);
            Pricing.ApplyCoupon_ByRef(ref total, 50);
            Pricing.RedeemLoyalty(ref c.LoyaltyPoints, ref total);

            Console.WriteLine("\n======RideEasy Invoice=====");
            Console.WriteLine($"Date: {ride.Date:dd-MMM-YYYY (ddd)}");
            Console.WriteLine($"Customer: {c.Name} ({c.Phone})");
            Console.WriteLine($"Vehicle: {v.Type}");
            Console.WriteLine($"Distance: {ride.Distance} km");
            Console.WriteLine($"Add-Ons: {string.Join(", ", addOns)}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Subtotal:\t\t₹ {sub:F2}");
            Console.WriteLine($"GST (18%):\t\t₹ {gst:F2}");
            Console.WriteLine($"Total (before):\t\t₹ {sub + gst:F2}");
            Console.WriteLine($"Coupun (by REF):\t- applied ₹50.00");
            Console.WriteLine($"Loyalty redeem:\t\t- applied up to available points");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Final Payable:\t\t₹ {total:F2}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"(Demonstration) Call-by-VALUE coupon attempt did NOT change total: ₹{beforeDiscount:F2}");
            Console.WriteLine($"Remaining Loyalty points: {c.LoyaltyPoints}");
            Console.WriteLine("\n==========================================");


        }
    }
}
