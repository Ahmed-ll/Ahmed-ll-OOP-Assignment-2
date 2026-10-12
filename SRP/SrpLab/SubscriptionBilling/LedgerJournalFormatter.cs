namespace SRC.SubscriptionBilling;

public sealed class LedgerJournalFormatter
{
    public string Format(string customerId, string invoiceNumber, decimal amount)
        => $"{customerId},{invoiceNumber},{amount:0.00},AR-SUB";
}