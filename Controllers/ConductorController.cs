using Marcel_Socolan_Proiect.Data;
using Microsoft.AspNetCore.Mvc;

namespace Marcel_Socolan_Proiect.Controllers;

public class ConductorController : Controller
{
    private readonly ILogger<ConductorController> _logger;
    private readonly ApplicationContext context;

    public ConductorController(ILogger<ConductorController> logger, ApplicationContext context)
    {
        _logger = logger;
        this.context = context;
    }

    public IActionResult Index()
    {
        return View(context.Conductors.AsEnumerable());
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
