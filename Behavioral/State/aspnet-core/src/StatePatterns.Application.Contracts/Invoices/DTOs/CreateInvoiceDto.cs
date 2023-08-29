using System;

namespace StatePatterns.Invoices.DTOs;

public class CreateInvoiceDto
{
    public long ValueCents { get; set; }
    public DateTime DueDate { get; set; }
}