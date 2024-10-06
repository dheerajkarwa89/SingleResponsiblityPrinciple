// See https://aka.ms/new-console-template for more information
using SingleResponsiblityPrinciple;

//Before applying SRP
Invoice _invoice = new Invoice();
_invoice.GenerateInvoice();
_invoice.PrintInvoice();
_invoice.SendInvoiceEmail();

//After applying SRP
InvoiceGenerator invoice = new InvoiceGenerator();
invoice.GenerateInvoice();

InvoicePrinter invoicePrinter = new InvoicePrinter();
invoicePrinter.PrintInvoice(invoice);

InvoiceEmailer invoiceEmailer = new InvoiceEmailer();
invoiceEmailer.SendEmail(invoice);
    