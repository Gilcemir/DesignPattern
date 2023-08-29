using Volo.Abp;

namespace StatePatterns.Invoices.ReceiptState;

public class ReceivedState : IReceiptState
{
    private readonly Invoice _invoice;

    public ReceivedState(Invoice invoice)
    {
        _invoice = invoice;
    }

    public void Cancel()
    {
        throw new UserFriendlyException("Failed to cancel invoice. Invalid state.");
    }

    public void Pay()
    {
        throw new UserFriendlyException("Failed to Pay invoice. Invalid state.");
    }

    public void Default()
    {
        throw new UserFriendlyException("Failed to Default invoice. Invalid state.");
    }

    public void Schedule()
    {
        throw new UserFriendlyException("Failed to schedule invoice. Invalid state.");
    }

    public void Transferred()
    {
        throw new UserFriendlyException("Failed to transfer invoice. Invalid state.");
    }
    public ReceiptStateEnumerator GetState => ReceiptStateEnumerator.Received;
}