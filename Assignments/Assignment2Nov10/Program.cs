using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Nov10
{
    class Onlinestore
    {
        public void Checkout(int price)
        {
            Console.WriteLine("Total amount to pay: Rs. " + price);
        }

        public void Checkout(int price,int quantity)
        {
            int total = price * quantity;
            Console.WriteLine("Total amount for " + quantity + " item(s): Rs. " + total);
        }

        public void Checkout(string couponCode)
        {
            
            Console.WriteLine("Coupon applied successfully! Coupon Code: " + couponCode);
        }

        public void Checkout(int price, int quantity, string couponCode)
        {
            int total = price * quantity;
            double discount = 0;

            if (couponCode == "SAVE10")
                discount = total * 0.10;
            else if(couponCode== "SAVE20")
                discount = total * 0.20;

            double finalAmount = total - discount;
            Console.WriteLine($"Applied Coupon: {couponCode}");
            Console.WriteLine($"Original Total: Rs. {total}");
            Console.WriteLine($"Discount: Rs. {discount}");
            Console.WriteLine($"Applied Coupon: {couponCode}");
            Console.WriteLine($"Final Amount to Pay: Rs.{finalAmount}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Onlinestore store= new Onlinestore();
            store.Checkout(500);
            store.Checkout(500, 3);
            store.Checkout("SAVE10");
            store.Checkout(500, 3, "SAVE10");
        }
    }
}
