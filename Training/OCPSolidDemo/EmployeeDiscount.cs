using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolidDemo
{
    public class EmployeeDiscount : IDiscount
    {
        public decimal GetDiscount()
        {
            return 0.5m;
        }
    }
}
