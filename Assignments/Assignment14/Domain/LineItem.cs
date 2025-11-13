using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment14.Contracts;

namespace Assignment14.Domain
{
    public class LineItem : ILineItem
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
    

    public LineItem(string name, int quantity, decimal unitPrice)
        {
            Name = name;
            Quantity = quantity;
            UnitPrice = unitPrice;

        }
    }
}
