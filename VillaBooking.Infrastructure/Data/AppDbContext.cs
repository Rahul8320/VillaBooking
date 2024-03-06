using Microsoft.EntityFrameworkCore;

namespace VillaBooking.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

}
