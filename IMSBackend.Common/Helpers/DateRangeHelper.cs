namespace IMSBackend.Common.Helpers;

public static class DateRangeHelper
{
    public static (string start, string end) GetDateRange(string range)
    {
        var end = DateTime.UtcNow; // Always end at "now"
        DateTime start;

        switch (range.ToUpper())
        {
            case "1D":
                start = end.AddDays(-1);
                break;
            case "1W":
                start = end.AddDays(-7);
                break;
            case "1M":
                start = end.AddMonths(-1);
                break;
            case "3M":
                start = end.AddMonths(-3);
                break;
            case "6M":
                start = end.AddMonths(-6);
                break;
            case "1Y":
                start = end.AddYears(-1);
                break;
            case "2Y":
                start = end.AddYears(-2);
                break;
            case "3Y":
                start = end.AddYears(-3);
                break;
            default:
                throw new ArgumentException("Invalid date range. Use 1D, 1W, 1M, 3M, 6M, or 1Y.");
        }

        return (start.ToString("yyyy-MM-dd"), end.ToString("yyyy-MM-dd"));
    }
}
