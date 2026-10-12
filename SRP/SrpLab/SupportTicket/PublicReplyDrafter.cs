namespace SrpLab;

public sealed class PublicReplyDrafter
{
    public string Draft(string ticketId, string priority, string agentName, DateTimeOffset nextUpdateBefore)
    {
        var apology = priority == "P1" ? "We are treating this as a critical incident." : "Thanks for reaching out.";
        return $"Hi,\n{apology}\nTicket {ticketId} is with {agentName}. Next update before {nextUpdateBefore:u}.\n";
    }
}
