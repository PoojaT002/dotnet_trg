using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentHelper.ShowSupportedMethods();

            IPaymentGateway CreditCard = new CreditCardPayment();
            CreditCard.ProcessPayment(1500);

            IPaymentGateway upi = new UPIPayment();
            upi.ProcessPayment(800);

            IPaymentGateway wallet = new WalletPayment();
            wallet.ProcessPayment(500);
        
        }
    }
}
