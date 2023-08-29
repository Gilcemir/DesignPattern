using System;

namespace StatePatterns.Invoices.ReceiptState;

public static class ReceiptStateExtensions
{
    public static IReceiptState GetInstanceByEnumerator(this ReceiptStateEnumerator enumerator, Invoice invoice)
    {
        return enumerator switch
        {
            ReceiptStateEnumerator.Default => new DefaultState(invoice),
            ReceiptStateEnumerator.NotApplicable => new NotApplicableState(invoice),
            ReceiptStateEnumerator.NotReceived => new NotReceivedState(invoice),
            ReceiptStateEnumerator.Received => new ReceivedState(invoice),
            ReceiptStateEnumerator.Scheduled => new ScheduledState(invoice),
            _ => throw new ArgumentOutOfRangeException(nameof(enumerator), enumerator, null)
        };
    }
}