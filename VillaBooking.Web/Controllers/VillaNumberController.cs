using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VillaBooking.Domain.Entities;
using VillaBooking.Infrastructure.Data;
using VillaBooking.Web.Models.ViewModels;

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
        var villaNumberVm = new VillaNumberVM()
        {
            VillaList = _context.Villas.ToList().Select(u => new SelectListItem()
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            }),
        };

        return View(villaNumberVm);
    }

    [HttpPost]
    public async Task<IActionResult> Create(VillaNumberVM model)
    {
        if (!ModelState.IsValid) return View();

        var existingVillaNumber = await _context.VillaNumbers.FindAsync(model.VillaNumber.Villa_Number);

        if (existingVillaNumber is not null)
        {
            TempData["error"] = $"Villa Number: {model.VillaNumber.Villa_Number} already exists.";
            return RedirectToAction("Create", "VillaNumber");
        }

        model.VillaNumber.CreatedDateTime = DateTime.UtcNow;
        model.VillaNumber.UpdatedDateTime = DateTime.UtcNow;

        _context.VillaNumbers.Add(model.VillaNumber);
        await _context.SaveChangesAsync();

        TempData["success"] = $"Villa Number: {model.VillaNumber.Villa_Number} created successfully.";
        _logger.LogInformation($"Villa Number: {model.VillaNumber.Villa_Number} created successfully.");
        return RedirectToAction("Index", "VillaNumber");
    }

    [HttpGet]
    public async Task<IActionResult> Update(int villaNumberId)
    {
        var villaNumberVm = new VillaNumberVM()
        {
            VillaList = _context.Villas.ToList().Select(u => new SelectListItem()
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            }),
            VillaNumber = await _context.VillaNumbers.FindAsync(villaNumberId),
        };

        if (villaNumberVm.VillaNumber == null)
        {
            return RedirectToAction("Error", "Home");
        }

        return View(villaNumberVm);
    }

    [HttpPost]
    public async Task<IActionResult> Update(VillaNumberVM model)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction(
                "Update",
                "VillaNumber",
                new {villaNumberId = model.VillaNumber.Villa_Number});
        }

        model.VillaNumber!.CreatedDateTime = model.VillaNumber.CreatedDateTime;
        model.VillaNumber.UpdatedDateTime = DateTime.UtcNow;

        _context.VillaNumbers.Update(model.VillaNumber);
        await _context.SaveChangesAsync();

        TempData["success"] = $"Villa Number: {model.VillaNumber.Villa_Number} updated successfully.";
        _logger.LogInformation($"Villa Number: {model.VillaNumber.Villa_Number} updated successfully.");
        return RedirectToAction("Index", "VillaNumber");
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int villaNumberId)
    {
        var villaNumberVm = new VillaNumberVM()
        {
            VillaList = _context.Villas.ToList().Select(u => new SelectListItem()
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            }),
            VillaNumber = await _context.VillaNumbers.FindAsync(villaNumberId),
        };

        if (villaNumberVm.VillaNumber is null)
        {
            return RedirectToAction("Error", "Home");
        }

        return View(villaNumberVm);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(VillaNumberVM model)
    {
        var villaNumber = await _context.VillaNumbers.FindAsync(model.VillaNumber?.Villa_Number);

        if (villaNumber is null)
        {
            return RedirectToAction("Error", "Home");
        }

        _context.VillaNumbers.Remove(villaNumber);
        await _context.SaveChangesAsync();

        TempData["success"] = $"Villa Number: {villaNumber.Villa_Number} deleted successfully.";
        _logger.LogInformation($"Villa Number: {villaNumber.Villa_Number} deleted successfully.");
        return RedirectToAction("Index", "VillaNumber");
    }
}
