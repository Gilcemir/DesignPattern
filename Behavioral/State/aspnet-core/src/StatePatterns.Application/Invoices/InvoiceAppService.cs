using System;
using System.Threading.Tasks;
using StatePatterns.Invoices.DTOs;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace StatePatterns.Invoices;

public class InvoiceAppService : ApplicationService, IInvoiceAppService
{
    private readonly InvoiceManager _invoiceManager;
private readonly IRepository<Invoice, Guid> _invoiceRepository;
    
    public InvoiceAppService(InvoiceManager invoiceManager, IRepository<Invoice, Guid> invoiceRepository)
    {
        _invoiceManager = invoiceManager;
        _invoiceRepository = invoiceRepository;
    }

    public async Task<InvoiceDto> CreateAsync(CreateInvoiceDto input)
        => ObjectMapper.Map<Invoice, InvoiceDto>(
            await _invoiceRepository.InsertAsync(
                _invoiceManager.Create(input.ValueCents, input.DueDate)
                )
            );
            
    

    public async Task<InvoiceDto> PayAsync(Guid id)
    {
        var invoice = await _invoiceRepository.GetAsync(id);
        InvoiceManager.Pay(invoice);
        invoice = await _invoiceRepository.UpdateAsync(invoice);
        return ObjectMapper.Map<Invoice, InvoiceDto>(invoice);
    }

    public async Task<InvoiceDto> DefaultAsync(Guid id)
    {
        var invoice = await _invoiceRepository.GetAsync(id);
        InvoiceManager.Default(invoice);
        invoice = await _invoiceRepository.UpdateAsync(invoice);
        return ObjectMapper.Map<Invoice, InvoiceDto>(invoice);
    }

    public async Task<InvoiceDto> ScheduleAsync(Guid id)
    {
        var invoice = await _invoiceRepository.GetAsync(id);
        InvoiceManager.Schedule(invoice);
        invoice = await _invoiceRepository.UpdateAsync(invoice);
        return ObjectMapper.Map<Invoice, InvoiceDto>(invoice);
    }

    public async Task<InvoiceDto> CancelAsync(Guid id)
    {
        var invoice = await _invoiceRepository.GetAsync(id);
        InvoiceManager.Cancel(invoice);
        invoice = await _invoiceRepository.UpdateAsync(invoice);
        return ObjectMapper.Map<Invoice, InvoiceDto>(invoice);
    }

    public async Task<InvoiceDto> TransferredAsync(Guid id)
    {
        var invoice = await _invoiceRepository.GetAsync(id);
        InvoiceManager.Transferred(invoice);
        invoice = await _invoiceRepository.UpdateAsync(invoice);
        return ObjectMapper.Map<Invoice, InvoiceDto>(invoice);
    }
}