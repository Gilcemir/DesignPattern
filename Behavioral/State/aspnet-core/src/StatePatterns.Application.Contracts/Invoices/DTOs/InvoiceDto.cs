using System;
using Volo.Abp.Application.Dtos;

namespace StatePatterns.Invoices.DTOs;

public class InvoiceDto : EntityDto<Guid>
{
    public long ValueCents { get; set; }
    public DateTime DueDate { get; set; }
    public string State { get; set; }
}