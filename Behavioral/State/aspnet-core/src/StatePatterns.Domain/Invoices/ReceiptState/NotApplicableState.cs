using Volo.Abp;

namespace StatePatterns.Invoices.ReceiptState;

public class NotApplicableState : IReceiptState
{
    private readonly Invoice _invoice;

    public NotApplicableState(Invoice invoice)
    {
        _invoice = invoice;
    }
    public void Cancel()
    {
        throw new UserFriendlyException("Failed to cancel invoice. Invalid state.");
    }

    public void Pay()
    {
        _invoice.SetState(new ReceivedState(_invoice));
    }

    public void Default()
    {
        throw new UserFriendlyException("Failed to default invoice. Invalid state.");
    }
    

    public void Schedule()
    {
        throw new UserFriendlyException("Failed to Schedule invoice. Invalid state.");
    }

    public void Transferred()
    {
        throw new UserFriendlyException("Failed to transfer invoice. Invalid state.");
    }
    public ReceiptStateEnumerator GetState => ReceiptStateEnumerator.NotApplicable;
}