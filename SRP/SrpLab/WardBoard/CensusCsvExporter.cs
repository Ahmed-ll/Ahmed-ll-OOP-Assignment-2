namespace SrpLab;

public sealed class CensusCsvExporter
{
    public string Export(IEnumerable<BedEntry> beds)
    {
        var lines = new List<string> { "bed,patient,acuity" };
        foreach (var b in beds)
            lines.Add($"{b.Bed},{b.PatientId},{b.Acuity}");
        return string.Join('\n', lines);
    }
}