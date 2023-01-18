using Marcel_Socolan_Proiect.Data;
using Marcel_Socolan_Proiect.Models;
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

    // Get
    public IActionResult Create()
    {
        return View();
    }

    // Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Passenger passenger)
    {
        if (ModelState.IsValid)
        {
            context.Passengers.Add(passenger);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(passenger);
    }

    public IActionResult Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var passenger = context.Passengers.FirstOrDefault(e => e.Id == id);
        if (passenger == null)
        {
            return NotFound();
        }
        return View(passenger);
    }

    // Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Passenger passenger)
    {
        if (ModelState.IsValid)
        {
            context.Passengers.Update(passenger);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(passenger);
    }

    public IActionResult Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var passenger = context.Passengers.FirstOrDefault(e => e.Id == id);
        if (passenger == null)
        {
            return NotFound();
        }
        return View(passenger);
    }

    // Post
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(Guid? id)
    {
        var passenger = context.Passengers.FirstOrDefault(e => e.Id == id);
        if (passenger == null)
        {
            return NotFound();
        }

        context.Passengers.Remove(passenger);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
}
