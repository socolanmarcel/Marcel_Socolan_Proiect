using System.Linq;
using Marcel_Socolan_Proiect.Data;
using Microsoft.AspNetCore.Mvc;

namespace Marcel_Socolan_Proiect.Controllers;

public class PassengerController : Controller
{
    private readonly ILogger<PassengerController> _logger;
    private readonly ApplicationContext context;

    public PassengerController(ILogger<PassengerController> logger, ApplicationContext context)
    {
        _logger = logger;
        this.context = context;
    }

    public IActionResult Index()
    {
        return View(context.Passengers.AsEnumerable());
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
