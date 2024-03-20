using Microsoft.AspNetCore.Mvc;
using VillaBooking.Application.IRepositories;
using VillaBooking.Domain.Entities;

namespace VillaBooking.Web.Controllers;

/// <summary>
/// Represents the villa controller for views.
/// </summary>
public class VillaController(IUnitOfWork unitOfWork, ILogger<VillaController> logger) : Controller
{
    /// <summary>
    /// Represents the villa repository interface.
    /// </summary>
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    private readonly ILogger<VillaController> _logger = logger;

    /// <summary>
    /// View list of all villa.
    /// </summary>
    /// <returns>Return villa index page with list of all villa.</returns>
    [HttpGet]
    public IActionResult Index()
    {
        try
        {
            var villas = _unitOfWork.Villa.GetAll();
            return View(villas);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur on GetAll Villa: {msg}", e.Message);
            return RedirectToAction("Error", "Home");
        }
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
        try
        {
            if (model.Name == model.Description)
            {
                _logger.LogError("The description cannot exactly match the Name.");
                ModelState.AddModelError("Description", "The description cannot exactly match the Name.");
            }

            if (!ModelState.IsValid) return View();

            model.CreatedDateTime = DateTime.UtcNow;
            model.UpdatedDateTime = DateTime.UtcNow;
            _unitOfWork.Villa.Add(model);
            await _unitOfWork.Villa.Save();
            _logger.LogInformation("Villa with id: {model.Id} is created successfully.", model.Id);
            TempData["success"] = $"Villa with id: {model.Id} is created successfully.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur on Create Villa: {msg}", e.Message);
            return RedirectToAction("Error", "Home");
        }
    }

    [HttpGet]
    public IActionResult Update(int? villaId)
    {
        try
        {
            var villa = _unitOfWork.Villa.Get(u => u.Id == villaId);

            if (villa is not null) return View(villa);

            TempData["error"] = $"Villa with id: {villaId} is not found!";
            return RedirectToAction("Error", "Home");
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur on Update Villa: {msg}", e.Message);
            return RedirectToAction("Error", "Home");
        }
    }

    [HttpPost]
    public async Task<IActionResult> Update(Villa model)
    {
        try
        {
            if (model.Name == model.Description)
            {
                ModelState.AddModelError("Description", "The description cannot exactly match the Name.");
            }

            if (!ModelState.IsValid) return View();

            model.UpdatedDateTime = DateTime.UtcNow;
            _unitOfWork.Villa.Update(model);
            await _unitOfWork.Villa.Save();
            _logger.LogInformation("Villa with id: {model.Id} is updated successfully.", model.Id);
            TempData["success"] = $"Villa with id: {model.Id} is updated successfully.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur on Update Villa: {msg}", e.Message);
            return RedirectToAction("Error", "Home");
        }
    }

    [HttpGet]
    public IActionResult Delete(int? villaId)
    {
        try
        {
            var villa = _unitOfWork.Villa.Get(u => u.Id == villaId);

            if (villa is not null) return View(villa);

            TempData["error"] = $"Villa with id: {villaId} is not found!";
            return RedirectToAction("Error", "Home");
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur on Delete Villa: {msg}", e.Message);
            return RedirectToAction("Error", "Home");
        }
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Villa model)
    {
        try
        {
            var villa = _unitOfWork.Villa.Get(u => u.Id == model.Id);

            if (villa is null)
            {
                TempData["error"] = $"Villa with id: {model.Id} is not found!";
                return RedirectToAction("Error", "Home");
            }

            _unitOfWork.Villa.Remove(villa);
            await _unitOfWork.Villa.Save();
            _logger.LogInformation("Villa with id: {model.Id} is deleted successfully.", model.Id);
            TempData["success"] = $"Villa with id: {model.Id} is deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error occur on Delete Villa: {msg}", e.Message);
            return RedirectToAction("Error", "Home");
        }
    }
}
