namespace StatePatterns.Invoices.ReceiptState;

public interface IReceiptState
{
    void Cancel();
    void Pay();
    void Default();
    /// <summary>
    /// Cobrança
    /// </summary>
    void Schedule();
    void Transferred();
    ReceiptStateEnumerator GetState { get; }
}

public enum ReceiptStateEnumerator
{
    NotApplicable,
    Received,
    Default,
    NotReceived,
    Scheduled
}