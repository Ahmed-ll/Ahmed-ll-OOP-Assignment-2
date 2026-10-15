namespace SRC.CheckoutBasket;

public sealed class CheckoutBasket
{
    private readonly List<(string Sku, decimal Price, int Qty)> _lines = new();
    public IReadOnlyList<(string Sku, decimal Price, int Qty)> Lines => _lines;

    public void AddLine(string sku, decimal price, int qty)
    {
        if (qty <= 0) throw new ArgumentOutOfRangeException(nameof(qty));
        _lines.Add((sku, price, qty));
    }

    public decimal SubTotal() => _lines.Sum(l => l.Price * l.Qty);
}