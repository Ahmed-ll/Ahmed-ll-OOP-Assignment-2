namespace SrpLab;

public sealed class PagerPolicy
{
    public string? PageFor(int bed, int acuity)
        => acuity >= 8 ? $"CODE-YELLOW bed={bed} at {DateTime.UtcNow:HH:mm}" : null;
}
