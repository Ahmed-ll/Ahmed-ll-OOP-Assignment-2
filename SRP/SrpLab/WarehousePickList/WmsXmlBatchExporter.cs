namespace SRC.WarehousePickList;

public sealed class WmsXmlBatchExporter
{
    public string Export(string batchId, IEnumerable<(string Sku, int Allocated)> allocations)
    {
        var parts = allocations.Select(a => $"<line sku=\"{a.Sku}\" qty=\"{a.Allocated}\" />");
        return $"<batch id=\"{batchId}\">{string.Join("", parts)}</batch>";
    }
}