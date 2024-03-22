using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaBooking.Application.IRepositories;
using VillaBooking.Domain.Entities;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Infrastructure.Repositories;

public class VillaNumberRepository(AppDbContext context) : Repository<VillaNumber>(context), IVillaNumberRepository
{
    private readonly AppDbContext _context = context;

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() == 0;
    }

    public void Update(VillaNumber entity)
    {
        _context.VillaNumbers.Update(entity);
    }
}
