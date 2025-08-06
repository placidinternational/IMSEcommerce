using IMSBackend.Common.Common;
using System.Linq.Expressions;

namespace IMSBackend.Domain.Common;

public interface IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetQueryable();
    Task<T> AddAsync(T entity);
    Task<List<T>> AddRangeAsync(List<T> list);
    Task<List<T>> AddRangeAsync(int batchSize, List<T> list, CancellationToken cancellationToken = default);
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
    Task<List<T>> DeleteRange(List<T> entities);
    Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken);
    Task<IEnumerable<T>> GetByExpression(Expression<Func<T, bool>> expression);
    Task<T> GetSingleByExpression(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
    Task<T?> FindByFirstOrDefaultAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
    Task<T?> FindBySingleOrDefaultAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
    Task<IReadOnlyList<T>> GetAllByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
}
