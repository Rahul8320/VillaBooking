using Microsoft.AspNetCore.Mvc;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Web.Controllers;

public class VillaController(AppDbContext context) : Controller
{
    private readonly AppDbContext _context = context;

    // GET
    public IActionResult Index()
    {
        var villas = _context.Villas.ToList();
        return View(villas);
    }
}
