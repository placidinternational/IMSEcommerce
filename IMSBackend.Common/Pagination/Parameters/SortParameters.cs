namespace IMSBackend.Common.Pagination.Parameters
{
    public class SortParameters
    {
        public SortingType SortType { get; set; }
    }

    public enum SortingType
    {
        Ascending,
        Descending,
    }
}
