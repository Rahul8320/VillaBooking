using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using VillaBooking.Application.IRepositories;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Infrastructure.Repositories;

public class Repository<T>(AppDbContext context) : IRepository<T>
    where T : class
{
    private readonly DbSet<T> _dbSet = context.Set<T>();

    public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet;

        if (filter is not null)
        {
            query = query.Where(filter);
        }

        if (!string.IsNullOrEmpty(includeProperties))
        {
            query = includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProp)
                    => current.Include(includeProp));
        }

        return query.ToList();
    }

    public T? Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet;
        query = query.Where(filter);

        if (!string.IsNullOrEmpty(includeProperties))
        {
            query = includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProp)
                    => current.Include(includeProp));
        }

        return query.FirstOrDefault();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }
}
