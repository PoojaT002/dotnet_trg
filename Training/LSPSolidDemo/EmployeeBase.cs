using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolidDemo
{
    public class EmployeeBase
    {
        public int Empid {  get; set; }
        public string Name { get; set; }
        public string EmpDept { get; set; }

        public virtual decimal GetBonus(decimal salary)
        {
            return salary * 0.10m;
        }
    }
}
