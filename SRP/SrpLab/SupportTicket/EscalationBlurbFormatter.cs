namespace SrpLab;

public sealed class EscalationBlurbFormatter
{
    public string Format(string ticketId, string priority, DateTimeOffset breachAt)
        => $"ESCALATE {ticketId} priority={priority} breachAt={breachAt:u} keywords-scanned=yes";
}