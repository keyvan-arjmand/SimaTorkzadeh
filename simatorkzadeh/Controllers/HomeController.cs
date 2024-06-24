using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using simatorkzadeh.Models;

namespace simatorkzadeh.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Resume()
    {
        return View();
    }   
    public IActionResult Research()
    {
        return View();
    }
    public IActionResult Skill()
    {
        return View();
    }
    public IActionResult Education()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    } 
    public IActionResult Experience()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}