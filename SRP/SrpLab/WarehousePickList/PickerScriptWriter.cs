namespace SRC.WarehousePickList;

public sealed class PickerScriptWriter
{
    public string Write(
        IReadOnlyList<(string Aisle, int Bin, string Sku, int Qty)> walkingOrder,
        IReadOnlyList<string> shortageSkus)
    {
        var steps = walkingOrder
            .Select((s, i) => $"{i + 1}. Go aisle {s.Aisle} bin {s.Bin}: pick {s.Qty} × {s.Sku}");
        var warn = shortageSkus.Count > 0
            ? "SHORTAGES: " + string.Join(", ", shortageSkus)
            : "SHORTAGES: none";
        return string.Join('\n', steps) + "\n" + warn;
    }
}
