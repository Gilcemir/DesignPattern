using Volo.Abp;

namespace StatePatterns.Invoices.ReceiptState;

public class NotReceivedState : IReceiptState
{
    private readonly Invoice _invoice;

    public NotReceivedState(Invoice invoice)
    {
        _invoice = invoice;
    }
    public void Cancel()
    {
        _invoice.SetState(new NotApplicableState(_invoice));
    }

    public void Pay()
    {
        // Aqui ele poderia ir para pagamento com diferença, mas vamos deixar para o próximo exemplo
        _invoice.SetState(new ReceivedState(_invoice));
    }

    public void Default()
    {
        _invoice.SetState(new DefaultState(_invoice));
    }

    public void Schedule()
    {
        _invoice.SetState(new ScheduledState(_invoice));
    }
    

    public void Transferred()
    {
        throw new UserFriendlyException("Failed to transfer invoice. Invalid state.");
    }
    public ReceiptStateEnumerator GetState => ReceiptStateEnumerator.NotReceived;
}