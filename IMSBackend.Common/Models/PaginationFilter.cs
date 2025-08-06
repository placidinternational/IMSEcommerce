namespace IMSBackend.Common.Models;
public class PaginationFilter
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public PaginationFilter()
    {
        this.PageNumber = 1;
        this.PageSize = PageSize;
    }

    public PaginationFilter(int pageNumber, int pageSize)
    {
        this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
        if (pageSize > 10)
        {
            this.PageSize = pageSize;
        }
        else
        {
            this.PageSize = 10;
        }
    }
}
public class SearchPaginationFilter
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string? SearchParams { get; set; }

    public SearchPaginationFilter()
    {
        this.PageNumber = 1;
        this.PageSize = PageSize;
    }

    public SearchPaginationFilter(int pageNumber, int pageSize)
    {
        this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
        if (pageSize > 10)
        {
            this.PageSize = pageSize;
        }
        else
        {
            this.PageSize = 10;
        }
    }
}