using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossBill

{
    internal class Item
    {
        public string Name;
        public int Quantity;
        public double PricePerPercent;

        public double GetTotal()
        {
            return Quantity * PricePerPercent;
        }
    }
}
