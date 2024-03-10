using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VillaBooking.Domain.Entities;
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

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(VillaNumber model)
    {
        if (!ModelState.IsValid) return View();

        model.CreatedDateTime = DateTime.UtcNow;
        model.UpdatedDateTime = DateTime.UtcNow;

        _context.VillaNumbers.Add(model);
        await _context.SaveChangesAsync();
        TempData["success"] = $"Villa Number: {model.Villa_Number} created successfully.";
        return RedirectToAction("Index", "VillaNumber");
    }
}
