using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblityPrinciple
{
    //Each class now handles only one responsibility
    public class InvoiceGenerator
    {
        public void GenerateInvoice()
        {
            //Invoice generation logic
        }
    }

    public class InvoicePrinter
    {
        public void PrintInvoice(InvoiceGenerator invoice)
        {
            //Invoice printing logic
        }
    }

    public class InvoiceEmailer
    {
        public void SendEmail(InvoiceGenerator invoice)
        { 
            //Logic to send invoice via email
        }
    }
}
