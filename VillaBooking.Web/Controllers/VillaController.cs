using Microsoft.AspNetCore.Mvc;
using VillaBooking.Domain.Entities;
using VillaBooking.Infrastructure.Data;

namespace VillaBooking.Web.Controllers;

/// <summary>
/// Represents the villa controller for views.
/// </summary>
/// <param name="context">The database context.</param>
public class VillaController(AppDbContext context) : Controller
{
    /// <summary>
    /// Represents the application database context.
    /// </summary>
    private readonly AppDbContext _context = context;

    /// <summary>
    /// View list of all villa.
    /// </summary>
    /// <returns>Return villa index page with list of all villa.</returns>
    [HttpGet]
    public IActionResult Index()
    {
        var villas = _context.Villas.ToList();
        return View(villas);
    }

    /// <summary>
    /// Create villa page.
    /// </summary>
    /// <returns>Return the create villa view page.</returns>
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Villa model)
    {
        if (ModelState.IsValid)
        {
            _context.Villas.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Villa");
        }

        return View();
    }
}
