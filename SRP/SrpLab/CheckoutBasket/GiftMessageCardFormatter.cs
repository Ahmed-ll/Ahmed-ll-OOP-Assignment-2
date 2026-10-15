namespace SRC.CheckoutBasket;

public sealed class GiftMessageCardFormatter
{
    public string Format(CheckoutBasket basket, string fromName, decimal grandTotal)
    {
        var items = string.Join(", ", basket.Lines.Select(l => l.Sku));
        return $"Dear friend,\nA gift from {fromName} awaits ({items}).\nTotal surprise value: {grandTotal:C}\n";
    }
}
