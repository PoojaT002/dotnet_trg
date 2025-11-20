using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolidDemo
{
    public class ContractEmployee : EmployeeBase
    {
        public override decimal GetBonus(decimal salary)
        {
            return 0;
        }
    }
}
