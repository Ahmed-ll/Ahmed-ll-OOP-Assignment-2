namespace SRC.LoanDesk;

internal class LoanDecisionLetterFormatter
{
    private readonly LoanDocumentService _documentService;

    public LoanDecisionLetterFormatter(LoanDocumentService documentService) => _documentService = documentService;

    public string DecisionLetter(string applicantName, LoanDesk loan)
    {
        if (loan.IsEligible())
        {
            var docs = _documentService.RequiredDocuments(loan);

            return $"Dear {applicantName},\n" +
                   $"Your request for {loan.RequestedAmount:C} is pre-approved " +
                   $"(risk {loan.RiskScore():0}).\n" +
                   $"Please upload: {string.Join("; ", docs)}.\n";
        }

        return $"Dear {applicantName},\n" +
               $"We are unable to approve {loan.RequestedAmount:C} at this time.\n" +
               $"Reference risk={loan.RiskScore():0}. " +
               "You may reapply after improving documentation.\n";
    }
}