namespace SRC.LoanDesk;

internal class LoanCsvExporter
{
    public string UnderwriterCsvRow(string applicationId, LoanDesk loan)
    {
        return $"{applicationId},{loan.CreditScore}," +
               $"{loan.EmploymentMonths},{(loan.HasCollateral ? 1 : 0)}," +
               $"{loan.RiskScore():0.00},{(loan.IsEligible() ? "Y" : "N")}";
    }
}