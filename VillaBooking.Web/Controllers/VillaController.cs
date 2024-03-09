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
        if (model.Name == model.Description)
        {
            ModelState.AddModelError("Description", "The description cannot exactly match the Name.");
        }

        if (!ModelState.IsValid) return View();

        model.CreatedDateTime = DateTime.UtcNow;
        model.UpdatedDateTime = DateTime.UtcNow;
        _context.Villas.Add(model);
        await _context.SaveChangesAsync();
        TempData["success"] = $"Villa with id: {model.Id} is created successfully.";
        return RedirectToAction("Index", "Villa");
    }

    [HttpGet]
    public async Task<IActionResult> Update(int? villaId)
    {
        var villa = await _context.Villas.FindAsync(villaId);

        if (villa is null)
        {
            TempData["error"] = $"Villa with id: {villaId} is not found!";
            return RedirectToAction("Error", "Home");
        }

        return View(villa);
    }

    [HttpPost]
    public async Task<IActionResult> Update(Villa model)
    {
        if (model.Name == model.Description)
        {
            ModelState.AddModelError("Description", "The description cannot exactly match the Name.");
        }

        if (!ModelState.IsValid) return View();

        model.UpdatedDateTime = DateTime.UtcNow;
        _context.Villas.Update(model);
        await _context.SaveChangesAsync();
        TempData["success"] = $"Villa with id: {model.Id} is updated successfully.";
        return RedirectToAction("Index", "Villa");
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int? villaId)
    {
        var villa = await _context.Villas.FindAsync(villaId);

        if (villa is null)
        {
            TempData["error"] = $"Villa with id: {villaId} is not found!";
            return RedirectToAction("Error", "Home");
        }

        return View(villa);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Villa model)
    {
        var villa = await _context.Villas.FindAsync(model.Id);

        if (villa is null)
        {
            TempData["error"] = $"Villa with id: {model.Id} is not found!";
            return RedirectToAction("Error", "Home");
        }

        _context.Villas.Remove(villa);
        await _context.SaveChangesAsync();
        TempData["success"] = $"Villa with id: {model.Id} is deleted successfully.";
        return RedirectToAction("Index", "Villa");
    }
}
