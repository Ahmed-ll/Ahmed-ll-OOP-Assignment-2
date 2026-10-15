namespace SRC.CourseEnrollmentDesk;

internal class TuitionInvoiceService
{
    public string TuitionInvoiceLine(string courseCode, bool isSeated, decimal tuition)
    {
        if (!isSeated)
            return $"{courseCode},WAITLIST,0.00";

        var vat = Math.Round(tuition * 0.14m, 2);
        var total = tuition + vat;

        return $"{courseCode},TUITION,{tuition:0.00},VAT,{vat:0.00},TOTAL,{total:0.00}";
    }
}
