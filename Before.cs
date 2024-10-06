using System;

namespace SingleResponsiblityPrinciple
{
    //All the operations are performed in invoice class
    public class Invoice
    {
        public void GenerateInvoice()
        {
            //generate invoice logic
        }

        public void PrintInvoice()
        {
            //print invoice logic
        }

        public void SendInvoiceEmail()
        {
            //email invoice logic
        }
    }
}