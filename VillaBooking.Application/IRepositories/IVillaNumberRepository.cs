using VillaBooking.Domain.Entities;

namespace VillaBooking.Application.IRepositories;

public interface IVillaNumberRepository : IRepository<VillaNumber>
{
    void Update(VillaNumber entity);
    Task<bool> Save();
}
