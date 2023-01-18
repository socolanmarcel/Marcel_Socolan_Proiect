using Marcel_Socolan_Proiect.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Marcel_Socolan_Proiect.Controllers;

[Authorize]
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

    // Get
    public IActionResult Create()
    {
        return View();
    }

    // Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Marcel_Socolan_Proiect.Models.Route route)
    {
        if (route.DepartureTime > route.ArrivalTime)
        {
            ModelState.AddModelError("DepartureTime", "Timpul de plecare nu poate fi dupa timpul de sosire.");
        }
        if (ModelState.IsValid)
        {
            context.Routes.Add(route);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(route);
    }

    public IActionResult Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var route = context.Routes.FirstOrDefault(e => e.Id == id);
        if (route == null)
        {
            return NotFound();
        }
        return View(route);
    }

    // Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Marcel_Socolan_Proiect.Models.Route route)
    {
        if (route.DepartureTime > route.ArrivalTime)
        {
            ModelState.AddModelError("DepartureTime", "Timpul de plecare nu poate fi dupa timpul de sosire.");
        }
        if (ModelState.IsValid)
        {
            context.Routes.Update(route);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(route);
    }

    public IActionResult Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var route = context.Routes.FirstOrDefault(e => e.Id == id);
        if (route == null)
        {
            return NotFound();
        }
        return View(route);
    }

    // Post
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(Guid? id)
    {
        var route = context.Routes.FirstOrDefault(e => e.Id == id);
        if (route == null)
        {
            return NotFound();
        }

        context.Routes.Remove(route);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
}
