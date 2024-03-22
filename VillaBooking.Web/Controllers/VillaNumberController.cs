using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VillaBooking.Application.IRepositories;
using VillaBooking.Web.Models.ViewModels;

namespace VillaBooking.Web.Controllers;

/// <summary>
/// Represents Villa Number Controller
/// </summary>
/// <param name="unitOfWork">The unit of work interface.</param>
public class VillaNumberController(IUnitOfWork unitOfWork, ILogger<VillaNumberController> logger) : Controller
{
    /// <summary>
    /// Represents the interface of unit of work.
    /// </summary>
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    private readonly ILogger<VillaNumberController> _logger = logger;

    [HttpGet]
    public IActionResult Index()
    {
        var villaNumbers = _unitOfWork.VillaNumber.GetAll(includeProperties: "Villa");
        return View(villaNumbers);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var villaNumberVm = new VillaNumberVM()
        {
            VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem()
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

        var existingVillaNumber = _unitOfWork.VillaNumber.Get(u => u.Villa_Number == model.VillaNumber.Villa_Number);

        if (existingVillaNumber is not null)
        {
            TempData["error"] = $"Villa Number: {model.VillaNumber.Villa_Number} already exists.";
            return RedirectToAction(nameof(Create));
        }

        model.VillaNumber.CreatedDateTime = DateTime.UtcNow;
        model.VillaNumber.UpdatedDateTime = DateTime.UtcNow;

        _unitOfWork.VillaNumber.Add(model.VillaNumber);
        await _unitOfWork.VillaNumber.Save();

        TempData["success"] = $"Villa Number: {model.VillaNumber.Villa_Number} created successfully.";
        _logger.LogInformation($"Villa Number: {model.VillaNumber.Villa_Number} created successfully.");
        return RedirectToAction("Index", "VillaNumber");
    }

    [HttpGet]
    public IActionResult Update(int villaNumberId)
    {
        var villaNumberVm = new VillaNumberVM()
        {
            VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem()
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            }),
            VillaNumber = _unitOfWork.VillaNumber.Get(u => u.Villa_Number == villaNumberId),
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
                nameof(Update),
                new {villaNumberId = model.VillaNumber.Villa_Number});
        }

        model.VillaNumber!.CreatedDateTime = model.VillaNumber.CreatedDateTime;
        model.VillaNumber.UpdatedDateTime = DateTime.UtcNow;

        _unitOfWork.VillaNumber.Update(model.VillaNumber);
        await _unitOfWork.VillaNumber.Save();

        TempData["success"] = $"Villa Number: {model.VillaNumber.Villa_Number} updated successfully.";
        _logger.LogInformation($"Villa Number: {model.VillaNumber.Villa_Number} updated successfully.");
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int villaNumberId)
    {
        var villaNumberVm = new VillaNumberVM()
        {
            VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem()
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            }),
            VillaNumber = _unitOfWork.VillaNumber.Get(u => u.Villa_Number == villaNumberId),
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
        var villaNumber = _unitOfWork.VillaNumber.Get(u => u.Villa_Number == model.VillaNumber.Villa_Number);

        if (villaNumber is null)
        {
            return RedirectToAction("Error", "Home");
        }

        _unitOfWork.VillaNumber.Remove(villaNumber);
        await _unitOfWork.VillaNumber.Save();

        TempData["success"] = $"Villa Number: {villaNumber.Villa_Number} deleted successfully.";
        _logger.LogInformation($"Villa Number: {villaNumber.Villa_Number} deleted successfully.");
        return RedirectToAction(nameof(Index));
    }
}
