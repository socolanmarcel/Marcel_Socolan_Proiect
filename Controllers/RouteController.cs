using Marcel_Socolan_Proiect.Data;
using Microsoft.AspNetCore.Mvc;

namespace Marcel_Socolan_Proiect.Controllers;

public class RouteController : Controller
{
    private readonly ILogger<RouteController> _logger;
    private readonly ApplicationContext context;

    public RouteController(ILogger<RouteController> logger, ApplicationContext context)
    {
        _logger = logger;
        this.context = context;
    }

    public IActionResult Index()
    {
        return View(context.Routes.AsEnumerable());
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
