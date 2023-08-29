using System;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace StatePatterns.Invoices;

public class InvoiceManager : DomainService
{
    public InvoiceManager()
    {
    }

    public Invoice Create(long valueCents, DateTime dueDate)
        => new Invoice(GuidGenerator.Create(), valueCents, dueDate);

    public static Invoice Pay(Invoice invoice)
    {
        invoice.Pay();
        return invoice;
    }
    
    public static Invoice Default(Invoice invoice)
    {
        invoice.Default();
        return invoice;
    }
    
    public static Invoice Schedule(Invoice invoice)
    {
        invoice.Schedule();
        return invoice;
    }

    public static Invoice Cancel(Invoice invoice)
    {
        invoice.Cancel();
        return invoice;
    }
    public static Invoice Transferred(Invoice invoice)
    {
        invoice.Transferred();
        return invoice;
    }
}