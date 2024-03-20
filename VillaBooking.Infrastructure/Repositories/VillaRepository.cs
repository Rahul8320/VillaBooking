using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VillaBooking.Application.IRepositories;
using VillaBooking.Domain.Entities;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Infrastructure.Repositories;

public class VillaRepository(AppDbContext context)
    : Repository<Villa>(context), IVillaRepository
{
    private readonly AppDbContext _context = context;

    public void Update(Villa entity)
    {
        _context.Villas.Update(entity);
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() == 0;
    }
}
