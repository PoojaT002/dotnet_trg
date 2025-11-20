using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class InvoiceRepository
    {
        public void SaveToDatabase(Invoice invoice)
        {
            Console.WriteLine("Invoice saved to Database");
        }
    }
}
