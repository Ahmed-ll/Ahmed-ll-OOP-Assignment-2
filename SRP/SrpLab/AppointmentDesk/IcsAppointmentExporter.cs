namespace SRC.AppointmentDesk;

public sealed class IcsAppointmentExporter
{
    public string ToIcs(DateTimeOffset start, DateTimeOffset end, string patientName, string clinician)
    {
        var uid = Guid.NewGuid();
        var startUtc = start.UtcDateTime;
        var endUtc = end.UtcDateTime;

        return "BEGIN:VCALENDAR\nVERSION:2.0\nBEGIN:VEVENT\n" +
               $"UID:{uid}\n" +
               $"DTSTART:{startUtc:yyyyMMdd'T'HHmmss'Z'}\n" +
               $"DTEND:{endUtc:yyyyMMdd'T'HHmmss'Z'}\n" +
               $"SUMMARY:Visit {patientName} / {clinician}\n" +
               "END:VEVENT\nEND:VCALENDAR\n";
    }
}