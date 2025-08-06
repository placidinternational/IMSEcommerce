using Microsoft.EntityFrameworkCore;
using IMSBackend.Common.Models;
using System.Linq.Expressions;

namespace IMSBackend.Common.Pagination;

public class PagedList<T> : List<T>
{
    public MetaData MetaData { get; set; }
    public List<T> Data { get; set; }
    
    public PagedList(List<T> items, int count, int pageNumber, int pageSize)
    {
        MetaData = new MetaData
        {
            TotalCount = count,
            PageSize = pageSize,
            CurrentPage = pageNumber,
            TotalPages = (int) Math.Ceiling(count / (double) pageSize)
        };
       this.Data = items;
    }
    
    public static async Task<PagedList<T>> ToPagedList(IQueryable<T> source, Expression<Func<T, bool>> filter, PaginationFilter parameter)
    {
        if (filter != null)
        {
            source = source.Where(filter);
        }
        
        var count =  await source.CountAsync();
        var items = await source.Skip((parameter.PageNumber - 1) * parameter.PageSize)
            .Take(parameter.PageSize).ToListAsync();
        
        return new PagedList<T>(items, count, parameter.PageNumber, parameter.PageSize);
    }

    public static async Task<PagedList<T>> ToPagedListAsync<T>(List<T> source, PaginationFilter parameter)
    {
        var count = source.Count;
        var items = source.Skip((parameter.PageNumber - 1) * parameter.PageSize).Take(parameter.PageSize).ToList();
        return await Task.FromResult(new PagedList<T>(items, count, parameter.PageNumber, parameter.PageSize));
    }
}