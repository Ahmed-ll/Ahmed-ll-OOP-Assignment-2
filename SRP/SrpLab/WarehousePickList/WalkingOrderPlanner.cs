namespace SRC.WarehousePickList;

public sealed class WalkingOrderPlanner
{
    public IReadOnlyList<(string Aisle, int Bin, string Sku, int Qty)> Plan(IEnumerable<PickLine> lines)
        => lines
            .OrderBy(l => l.Aisle)
            .ThenBy(l => l.Bin)
            .Select(l => (l.Aisle, l.Bin, l.Sku, Qty: Math.Min(l.QtyNeeded, l.QtyOnHand)))
            .Where(x => x.Qty > 0)
            .ToList();
}
