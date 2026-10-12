namespace SRC.LoanDesk;

internal class LoanDocumentService
{
    public IReadOnlyList<string> RequiredDocuments(LoanDesk loan)
    {
        var docs = new List<string>
        {
            "National ID",
            "Proof of income (3 months)"
        };

        if (loan.RequestedAmount > 40_000m)
            docs.Add("Bank statements (6 months)");

        if (loan.HasCollateral)
            docs.Add("Collateral ownership deed");

        if (loan.EmploymentMonths < 12)
            docs.Add("Employer letter");

        if (!loan.IsEligible())
            docs.Add("Manual underwriter referral form");

        return docs;
    }
}