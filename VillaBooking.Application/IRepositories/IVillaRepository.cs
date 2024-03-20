using System.Linq.Expressions;
using VillaBooking.Domain.Entities;

namespace VillaBooking.Application.IRepositories;

public interface IVillaRepository : IRepository<Villa>
{
    void Update(Villa entity);
    Task<bool> Save();
}
