namespace SRC.KitchenTicket;

internal class ExpoLaneSelector
{
    private readonly AllergenDetector _allergenDetector;
    private readonly KitchenTimeEstimator _timeEstimator;

    public ExpoLaneSelector( AllergenDetector allergenDetector, KitchenTimeEstimator timeEstimator)
    {
        _allergenDetector = allergenDetector;
        _timeEstimator = timeEstimator;
    }

    public string ExpoLaneHint(KitchenTicket ticket)
    {
        if (_allergenDetector.DetectAllergens(ticket).Count > 0) return "LANE-ALLERGY";
        return _timeEstimator.EstimatedReadyMinutes(ticket, 2) > 20 ? "LANE-SLOW" : "LANE-FAST";
    }
}