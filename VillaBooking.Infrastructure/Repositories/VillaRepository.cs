using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VillaBooking.Application.IRepositories;
using VillaBooking.Domain.Entities;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Infrastructure.Repositories;

public class VillaRepository(AppDbContext context, ILogger<VillaRepository> logger)
    : Repository<Villa>(context), IVillaRepository
{
    private readonly AppDbContext _context = context;

    public void Update(Villa entity)
    {
        try
        {
            _context.Villas.Update(entity);
        }
        catch (Exception e)
        {
            logger.LogError(e, "Error occur in Update Villa: {msg}", e.Message);
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
            logger.LogError(e, "Error occur in Save Villa: {msg}", e.Message);
            throw;
        }
    }
}
