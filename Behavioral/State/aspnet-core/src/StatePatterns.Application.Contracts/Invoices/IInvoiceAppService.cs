using System;
using System.Threading.Tasks;
using StatePatterns.Invoices.DTOs;
using Volo.Abp.Application.Services;

namespace StatePatterns.Invoices;

public interface IInvoiceAppService : IApplicationService
{
    Task<InvoiceDto> CreateAsync(CreateInvoiceDto input);
    Task<InvoiceDto> PayAsync(Guid id);
    Task<InvoiceDto> DefaultAsync(Guid id);
    Task<InvoiceDto> ScheduleAsync(Guid id);
    Task<InvoiceDto> CancelAsync(Guid id);
    Task<InvoiceDto> TransferredAsync(Guid id);
}