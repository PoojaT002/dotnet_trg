using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class EmailService
    {
        public void SendEmail(Invoice invoice)
        {
            Console.WriteLine("Invoice Email sent to customer.");
        }
    }
}
