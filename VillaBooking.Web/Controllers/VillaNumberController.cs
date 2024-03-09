using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Web.Controllers;

/// <summary>
/// Represents Villa Number Controller
/// </summary>
/// <param name="context">The application db context</param>
public class VillaNumberController(AppDbContext context, ILogger<VillaNumberController> logger) : Controller
{
    /// <summary>
    /// Represents the application database context.
    /// </summary>
    private readonly AppDbContext _context = context;

    private readonly ILogger<VillaNumberController> _logger = logger;

    [HttpGet]
    public IActionResult Index()
    {
        var villaNumbers = _context.VillaNumbers.Include(u => u.Villa).ToList();
        return View(villaNumbers);
    }
}
