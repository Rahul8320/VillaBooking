using Microsoft.AspNetCore.Mvc;
using VillaBooking.Application.IRepositories;
using VillaBooking.Domain.Entities;

namespace VillaBooking.Web.Controllers;

/// <summary>
/// Represents the villa controller for views.
/// </summary>
public class VillaController(IVillaRepository villaRepository, ILogger<VillaController> logger) : Controller
{
    /// <summary>
    /// Represents the villa repository interface.
    /// </summary>
    private readonly IVillaRepository _villaRepository = villaRepository;

    private readonly ILogger<VillaController> _logger = logger;

    /// <summary>
    /// View list of all villa.
    /// </summary>
    /// <returns>Return villa index page with list of all villa.</returns>
    [HttpGet]
    public IActionResult Index()
    {
        var villas = _villaRepository.GetAll();
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
            _logger.LogError("The description cannot exactly match the Name.");
            ModelState.AddModelError("Description", "The description cannot exactly match the Name.");
        }

        if (!ModelState.IsValid) return View();

        model.CreatedDateTime = DateTime.UtcNow;
        model.UpdatedDateTime = DateTime.UtcNow;
        _villaRepository.Add(model);
        await _villaRepository.Save();
        _logger.LogInformation("Villa with id: {model.Id} is created successfully.", model.Id);
        TempData["success"] = $"Villa with id: {model.Id} is created successfully.";
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int? villaId)
    {
        var villa = _villaRepository.Get(u => u.Id == villaId);

        if (villa is not null) return View(villa);

        TempData["error"] = $"Villa with id: {villaId} is not found!";
        return RedirectToAction("Error", "Home");
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
        _villaRepository.Update(model);
        await _villaRepository.Save();
        _logger.LogInformation("Villa with id: {model.Id} is updated successfully.", model.Id);
        TempData["success"] = $"Villa with id: {model.Id} is updated successfully.";
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int? villaId)
    {
        var villa = _villaRepository.Get(u => u.Id == villaId);

        if (villa is not null) return View(villa);

        TempData["error"] = $"Villa with id: {villaId} is not found!";
        return RedirectToAction("Error", "Home");
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Villa model)
    {
        var villa = _villaRepository.Get(u => u.Id == model.Id);

        if (villa is null)
        {
            TempData["error"] = $"Villa with id: {model.Id} is not found!";
            return RedirectToAction("Error", "Home");
        }

        _villaRepository.Remove(villa);
        await _villaRepository.Save();
        _logger.LogInformation("Villa with id: {model.Id} is deleted successfully.", model.Id);
        TempData["success"] = $"Villa with id: {model.Id} is deleted successfully.";
        return RedirectToAction(nameof(Index));
    }
}
