using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.GenerateInvoice();

            InvoiceRepository invoiceRepository = new InvoiceRepository();
            invoiceRepository.SaveToDatabase(invoice);

            EmailService emailService = new EmailService();
            emailService.SendEmail(invoice);
        }
    }
}
