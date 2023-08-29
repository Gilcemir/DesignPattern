using Volo.Abp;

namespace StatePatterns.Invoices.ReceiptState;

public class ScheduledState : IReceiptState
{
    private readonly Invoice _invoice;

    public ScheduledState(Invoice invoice)
    {
        _invoice = invoice;
    }

    public void Cancel()
    {
        throw new UserFriendlyException("Failed to cancel invoice. Invalid state.");
    }

    public void Pay()
    {
        throw new UserFriendlyException("Failed to pay invoice. Invalid state.");
    }

    public void Default()
    {
        throw new UserFriendlyException("Failed to cancel invoice. Invalid state.");
    }

    public void Schedule()
    {
        throw new UserFriendlyException("Failed to schedule invoice. Invalid state.");
    }
    public void Transferred()
    {
        _invoice.SetState(new ReceivedState(_invoice));
    }
    public ReceiptStateEnumerator GetState => ReceiptStateEnumerator.Scheduled;
}