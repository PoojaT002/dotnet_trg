using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Nov10
{
    abstract class ShippingCalculator
    {
        public abstract decimal Calculate(decimal weight, string zone);
        public virtual string Label()
        {
            return "Generic Shipping Service";
        }
    }
    class StandardShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal rate = (zone == "Local") ? 50m : 70m;
            return weight * rate;
        }

        public override string Label()
        {
            return "Standard Shipping (Delivery : 3-5 days)";
        }
    }
    class ExpressShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal rate = (zone == "Local") ? 100m : 130m;
            return weight * rate;
        }

        public override string Label()
        {
            return "Express Shipping (Delivery: 1-2 days)";
        }
    }

    class InternationalShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal rate = (zone == "Asia") ? 500m : 800m;
            return weight * rate;
        }

        public override string Label()
        {
            return "International Shipping (Delivery: 5-10 days)";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                ShippingCalculator standard = new StandardShipping();
                ShippingCalculator express = new ExpressShipping();
                ShippingCalculator international = new InternationalShipping();

                Console.WriteLine(standard.Label());
                Console.WriteLine("Cost: Rs" + standard.Calculate(2.5m, "Local"));
                Console.WriteLine();

                Console.WriteLine(express.Label());
                Console.WriteLine("Cost: Rs" + express.Calculate(2.5m, "Other"));
                Console.WriteLine();

                Console.WriteLine(international.Label());
                Console.WriteLine("Cost: Rs" + international.Calculate(3m, "Aisa"));



            }
        }
    }
}
   
