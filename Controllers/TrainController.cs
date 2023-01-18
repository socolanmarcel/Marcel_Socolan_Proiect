using Marcel_Socolan_Proiect.Data;
using Microsoft.AspNetCore.Mvc;

namespace Marcel_Socolan_Proiect.Controllers;

public class TrainController : Controller
{
    private readonly ILogger<TrainController> _logger;
    private readonly ApplicationContext context;

    public TrainController(ILogger<TrainController> logger, ApplicationContext context)
    {
        _logger = logger;
        this.context = context;
    }

    public IActionResult Index()
    {
        return View(context.Trains.AsEnumerable());
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
