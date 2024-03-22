using Microsoft.Extensions.Logging;
using VillaBooking.Application.IRepositories;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Infrastructure.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public IVillaRepository Villa { get; init; } = new VillaRepository(context);
    public IVillaNumberRepository VillaNumber { get; init; } = new VillaNumberRepository(context);
}
