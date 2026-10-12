namespace SRC.AppointmentDesk;

public class ClinicBusinessHoursPolicy
{
    public TimeOnly Open { get; }
    public TimeOnly Close { get; }
    public int SlotMinutes { get; }

    public ClinicBusinessHoursPolicy(TimeOnly open, TimeOnly close, int slotMinutes)
    {
        if (slotMinutes <= 0)
            throw new ArgumentOutOfRangeException("Slot duration must be greater than zero.");

        Open = open;
        Close = close;
        SlotMinutes = slotMinutes;
    }
    
    public bool IsWithinBusinessHours(DateTimeOffset when)
    {
        if (when.DayOfWeek is DayOfWeek.Friday or DayOfWeek.Saturday) return false;
        var time = TimeOnly.FromDateTime(when.DateTime);
        return time >= Open && time.AddMinutes(SlotMinutes) <= Close;
    }
}
