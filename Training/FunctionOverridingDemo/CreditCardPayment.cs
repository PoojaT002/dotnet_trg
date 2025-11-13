using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
    public class CreditCardPayment : PaymentMethod
    {
        
        public override string Provider => "Credit Card  Provider";
        public override bool ProcessPayment(decimal amount)
        {
            base.ProcessPayment(788);
            if (amount > 0 && amount <=5000)
            {
                Console.WriteLine($"Processing Credit Card payment of {amount:c} through {Provider}.");
                return true;
            }
            else
            {
                Console.WriteLine("Credit card payment failed: Amount exceeds limit or is inavlid.");
                return false;
            }

        }
    }
    
}
