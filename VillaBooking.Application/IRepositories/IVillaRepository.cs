using System.Linq.Expressions;
using VillaBooking.Domain.Entities;

namespace VillaBooking.Application.IRepositories;

public interface IVillaRepository
{
    IEnumerable<Villa> GetAll(Expression<Func<Villa, bool>>? filter = null, string? includeProperties = null);
    Villa? Get(Expression<Func<Villa, bool>> filter, string? includeProperties = null);
    void Add(Villa entity);
    void Update(Villa entity);
    void Remove(Villa entity);
    Task<bool> Save();
}
