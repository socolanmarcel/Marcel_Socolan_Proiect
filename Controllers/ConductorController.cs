using Marcel_Socolan_Proiect.Data;
using Marcel_Socolan_Proiect.Models;
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

    // Get
    public IActionResult Create()
    {
        return View();
    }

    // Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Conductor conductor)
    {
        if (ModelState.IsValid)
        {
            context.Conductors.Add(conductor);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(conductor);
    }

    public IActionResult Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var conductor = context.Conductors.FirstOrDefault(e => e.Id == id);
        if (conductor == null)
        {
            return NotFound();
        }
        return View(conductor);
    }

    // Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Conductor conductor)
    {
        if (ModelState.IsValid)
        {
            context.Conductors.Update(conductor);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(conductor);
    }

    public IActionResult Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var conductor = context.Conductors.FirstOrDefault(e => e.Id == id);
        if (conductor == null)
        {
            return NotFound();
        }
        return View(conductor);
    }

    // Post
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(Guid? id)
    {
        var conductor = context.Conductors.FirstOrDefault(e => e.Id == id);
        if (conductor == null)
        {
            return NotFound();
        }

        context.Conductors.Remove(conductor);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
}
