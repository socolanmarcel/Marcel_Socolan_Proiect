using Marcel_Socolan_Proiect.Data;
using Marcel_Socolan_Proiect.Models;
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

    // Get
    public IActionResult Create()
    {
        return View();
    }

    // Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Train train)
    {
        if (ModelState.IsValid)
        {
            context.Trains.Add(train);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(train);
    }

    public IActionResult Edit(int id)
    {
        if (id <= 0)
        {
            return NotFound();
        }

        var train = context.Trains.FirstOrDefault(e => e.Id == id);
        if (train == null)
        {
            return NotFound();
        }
        return View(train);
    }

    // Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Train train)
    {
        if (ModelState.IsValid)
        {
            context.Trains.Update(train);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(train);
    }

    public IActionResult Delete(int id)
    {
        if (id <= 0)
        {
            return NotFound();
        }

        var train = context.Trains.FirstOrDefault(e => e.Id == id);
        if (train == null)
        {
            return NotFound();
        }
        return View(train);
    }

    // Post
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(int id)
    {
        var train = context.Trains.FirstOrDefault(e => e.Id == id);
        if (train == null)
        {
            return NotFound();
        }

        context.Trains.Remove(train);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
}
