namespace SRC.KitchenTicket;

internal class ThermalTicketFormatter
{
    private readonly AllergenDetector _allergenDetector;
    private readonly KitchenTimeEstimator _timeEstimator;

    public ThermalTicketFormatter(AllergenDetector allergenDetector, KitchenTimeEstimator timeEstimator)
    {
        _allergenDetector = allergenDetector;
        _timeEstimator = timeEstimator;
    }

    public string RenderThermalTicket(KitchenTicket ticket, int orderNumber)
    {
        var width = 32;
        var line = new string('=', width);

        var body = string.Join('\n', ticket.Items.Select(i =>
            $"* {i.Item.ToUpperInvariant()} ({i.PrepMinutes}m)"));

        var allergens = _allergenDetector.DetectAllergens(ticket);

        var allergyLine = allergens.Count == 0
            ? "ALLERGENS: none"
            : "ALLERGENS: " + string.Join(",", allergens);

        var eta = _timeEstimator.EstimatedReadyMinutes(ticket, 2);

        return $"{line}\nORDER #{orderNumber}\nETA {eta} MIN\n{body}\n{allergyLine}\n{line}\n";
    }
}