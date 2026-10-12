namespace SrpLab;

public sealed class HandoffNoteFormatter
{
    public string Format(int bed, BedEntry? entry)
    {
        if (entry is null)
            return $"Bed {bed}: empty";

        var tone = entry.Acuity >= 8 ? "ESCALATE" : entry.Acuity >= 4 ? "WATCH" : "STABLE";
        return $"[HANDOFF {DateTime.UtcNow:yyyy-MM-dd}] Bed {bed} · {entry.PatientId} · acuity={entry.Acuity} · {tone}";
    }
}
