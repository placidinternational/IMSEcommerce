using IMSBackend.Persistence.Context;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using IMSBackend.Common.Common;
using IMSBackend.Domain.Common;

namespace IMSBackend.Persistence.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly IMSEcommerceContext dbContext;

    protected Repository(IMSEcommerceContext _DbContext)
    {
        dbContext = _DbContext;
    }

    public async Task<T> AddAsync(T entity)
    {
        await dbContext.Set<T>().AddAsync(entity);
        return entity;
    }

    public async Task<List<T>> AddRangeAsync(List<T> list)
    {
        await dbContext.Set<T>().AddRangeAsync(list);
        return list;
    }

    public async Task<T> Update(T newEntity)
    {
        dbContext.Set<T>().Attach(newEntity);
        dbContext.Entry(newEntity).State = EntityState.Modified;

        return newEntity;
    }

    public async Task<T> Delete(T entity)
    {
        dbContext.Set<T>().Remove(entity);
        return entity;
    }
    public async Task<List<T>> DeleteRange(List<T> entities)
    {
        dbContext.Set<T>().RemoveRange(entities);
        return entities;
    }


    public async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<T>().FindAsync(id, cancellationToken);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await dbContext.Set<T>().ToListAsync(cancellationToken);
    }
    public async Task<IReadOnlyList<T>> GetAllByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
    {
        return await dbContext.Set<T>().Where(expression).ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<T>> GetByExpression(Expression<Func<T, bool>> expression)
    {
        return dbContext.Set<T>().Where(expression);
    }
    public async Task<T> GetSingleByExpression(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
    {
        return await dbContext.Set<T>().Where(expression).FirstOrDefaultAsync(cancellationToken);
    }

    public Task<T?> FindByFirstOrDefaultAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
    {
        return dbContext.Set<T>().FirstOrDefaultAsync(expression, cancellationToken);
    }
    public Task<T?> FindBySingleOrDefaultAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
    {
        return dbContext.Set<T>().SingleOrDefaultAsync(expression, cancellationToken);
    }
    public IQueryable<T> GetQueryable()
    {
        return dbContext.Set<T>();
    }

    public async Task<List<T>> AddRangeAsync(int batchSize, List<T> list, CancellationToken cancellationToken = default)
    {
        if (list == null || !list.Any())
            return new List<T>();
        for (int i = 0; i < list.Count; i += batchSize)
        {
            var batch = list.Skip(i).Take(batchSize).ToList();
            await dbContext.Set<T>().AddRangeAsync(batch, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken); // Commit per batch
        }

        return list;
    }

}
