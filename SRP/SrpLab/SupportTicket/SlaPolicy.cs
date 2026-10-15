namespace SrpLab;

public sealed class SlaPolicy
{
    public DateTimeOffset DeadlineFor(DateTimeOffset openedAt, string priority)
    {
        var hours = priority switch
        {
            "P1" => 4,
            "P2" => 24,
            _ => 72
        };
        return openedAt.AddHours(hours);
    }

    public bool IsBreached(DateTimeOffset openedAt, string priority, DateTimeOffset now)
        => now > DeadlineFor(openedAt, priority);
}
