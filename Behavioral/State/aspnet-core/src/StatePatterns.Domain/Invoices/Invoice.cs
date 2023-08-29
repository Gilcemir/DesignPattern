using System;
using StatePatterns.Invoices.ReceiptState;
using Volo.Abp.Domain.Entities.Auditing;

namespace StatePatterns.Invoices;

public class Invoice : FullAuditedAggregateRoot<Guid>
{
    private IReceiptState _receiptState => State.GetInstanceByEnumerator(this);
    public ReceiptStateEnumerator State { get; private set; }

    public long ValueCents { get; set; }

    public DateTime DueDate { get; set; }
    

    public Invoice(Guid id, long valueCents, DateTime dueDate) : base(id)
    {
        State = ReceiptStateEnumerator.NotReceived;
        ValueCents = valueCents;
        DueDate = dueDate;
    }

    public void SetState(IReceiptState state)
    {
        State = state.GetState;
    }

    internal void Pay()
    {
        _receiptState.Pay();
    }

    internal void Default()
    {
        _receiptState.Default();
    }

    internal void Schedule()
    {
        _receiptState.Schedule();
    }

    internal void Cancel()
    {
        _receiptState.Cancel();
    }
    
    internal void Transferred()
    {
        _receiptState.Transferred();
    }
}