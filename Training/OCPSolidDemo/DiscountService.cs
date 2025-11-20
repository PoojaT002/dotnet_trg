using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolidDemo
{
    public class DiscountService
    {
        public decimal ApplyDiscount(IDiscount discount)
        {
            return discount.GetDiscount();
        }
    }
}
