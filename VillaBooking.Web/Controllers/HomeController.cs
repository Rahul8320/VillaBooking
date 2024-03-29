using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VillaBooking.Web.Models;

namespace VillaBooking.Web.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Error()
    {
        _logger.LogError("Something happened wrong!");
        return View();
    }
}
