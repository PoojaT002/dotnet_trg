using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
    public class CashOnDelivary : PaymentMethod
    {
        public override string Provider => "Cash on Delivary";
    }
}
