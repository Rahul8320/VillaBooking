using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VillaBooking.Application.IRepositories;
using VillaBooking.Domain.Entities;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Infrastructure.Repositories;

public class VillaRepository(AppDbContext context, ILogger<VillaRepository> logger) : IVillaRepository
{
    private readonly AppDbContext _context = context;
    private readonly ILogger<VillaRepository> _logger = logger;

    public IEnumerable<Villa> GetAll(Expression<Func<Villa, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            IQueryable<Villa> query = _context.Set<Villa>();

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
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur in GetAll Villa: {msg}", e.Message);
            throw;
        }
    }

    public Villa? Get(Expression<Func<Villa, bool>> filter, string? includeProperties = null)
    {
        try
        {
            IQueryable<Villa> query = _context.Set<Villa>();

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
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur in Get Villa: {msg}", e.Message);
            throw;
        }
    }

    public void Add(Villa entity)
    {
        try
        {
            _context.Villas.Add(entity);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur in Add Villa: {msg}", e.Message);
            throw;
        }
    }

    public void Update(Villa entity)
    {
        try
        {
            _context.Villas.Update(entity);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur in Update Villa: {msg}", e.Message);
            throw;
        }
    }

    public void Remove(Villa entity)
    {
        try
        {
            _context.Villas.Remove(entity);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur in Remove Villa: {msg}", e.Message);
            throw;
        }
    }

    public async Task<bool> Save()
    {
        try
        {
            return await _context.SaveChangesAsync() == 0;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur in Save Villa: {msg}", e.Message);
            throw;
        }
    }
}
