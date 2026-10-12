namespace SrpLab;

public sealed record BedEntry(int Bed, string PatientId, int Acuity);

public sealed class WardBoard
{
    private readonly Dictionary<int, BedEntry> _beds = new();

    public void AssignBed(int bed, string patientId, int acuity)
    {
        if (bed <= 0) throw new ArgumentOutOfRangeException(nameof(bed));
        if (string.IsNullOrWhiteSpace(patientId)) throw new ArgumentException("patient required");

        _beds[bed] = new BedEntry(bed, patientId.Trim().ToUpperInvariant(), acuity);
    }

    public BedEntry? Find(int bed) => _beds.GetValueOrDefault(bed);

    public IReadOnlyList<BedEntry> Census() => _beds.Values.OrderBy(b => b.Bed).ToList();
}
