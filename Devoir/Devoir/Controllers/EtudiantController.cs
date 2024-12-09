using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Devoir.Models;

namespace Devoir.Controllers;

public class EtudiantController : Controller
{
    private readonly ILogger<EtudiantController> _logger;

    public EtudiantController(ILogger<EtudiantController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}