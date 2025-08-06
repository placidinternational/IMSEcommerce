namespace IMSBackend.Common.Pagination.Parameters;

public class FilterParameters : RequestParameters
{
    // Filter Parameters Here
    public uint MinAmount { get; set; }
    public uint MaxAmount { get; set; } = int.MaxValue;
    public bool ValidAmount => MaxAmount > MinAmount;
    public string SearchTerm { get; set; } = string.Empty;
}