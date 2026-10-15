namespace SRC.CourseEnrollmentDesk;

internal class WelcomePacketFormatter
{
    public string CourseCode { get; }
    public WelcomePacketFormatter(string courseCode) => CourseCode = courseCode;

    public string WelcomePacketMarkdown(string studentName,bool isSeated,int waitlistPosition)
    {
        var status = isSeated ? "confirmed seat" : $"waitlist #{waitlistPosition}";

        return $"# Welcome to {CourseCode}\n" +
               $"Hi {studentName},\n" +
               $"Your status: **{status}**.\n" +
               $"Bring a laptop. Discord onboarding link: " +
               $"https://example.invalid/{CourseCode.ToLowerInvariant()}\n";
    }
}
