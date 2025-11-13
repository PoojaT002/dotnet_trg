using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment cardPayment = new CreditCardPayment();
            cardPayment.ProcessPayment(3000);
            cardPayment.samplePayment();
            Console.WriteLine($"{cardPayment.Provider}");
            CashOnDelivary cashOnDelivary = new CashOnDelivary();
            cashOnDelivary.ProcessPayment(7000);
            Console.ReadLine();
        }
    }
}
