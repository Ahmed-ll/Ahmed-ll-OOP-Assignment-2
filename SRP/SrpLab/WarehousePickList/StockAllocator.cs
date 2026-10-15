namespace SRC.WarehousePickList;

public sealed class StockAllocator
{
    public IReadOnlyList<(string Sku, int Allocated)> Allocate(IEnumerable<PickLine> lines)
    {
        var result = new List<(string Sku, int Allocated)>();
        foreach (var line in lines)
        {
            var alloc = Math.Min(line.QtyNeeded, line.QtyOnHand);
            result.Add((line.Sku, alloc));
        }
        return result;
    }

    public IReadOnlyList<string> Shortfalls(IReadOnlyList<PickLine> lines)
        => Allocate(lines)
            .Where(a => a.Allocated < lines.First(l => l.Sku == a.Sku).QtyNeeded)
            .Select(a => a.Sku)
            .ToList();
}
