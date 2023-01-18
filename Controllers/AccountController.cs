using Microsoft.AspNetCore.Mvc;
using Marcel_Socolan_Proiect.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Marcel_Socolan_Proiect.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Marcel_Socolan_Proiect.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationContext context;

    public AccountController(ILogger<HomeController> logger, ApplicationContext context)
    {
        _logger = logger;
        this.context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(UserModel userModel)
    {
        if (!ModelState.IsValid) return View();

        // Verificarea datelor de logare:
        var claims = new List<Claim>();

        var user = this.context.Users.FirstOrDefault(e => e.Username == userModel.Username);

        if (user != null && user.Password == userModel.Password)
        {
            claims.Add(new Claim(ClaimTypes.Name, userModel.Username));
            if (user.Role == "admin")
            {
                claims.Add(new Claim(ClaimTypes.Role, "admin"));
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, "user"));
            }

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            // Plasam un cookie in browserul utilizatorului
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

            return RedirectToAction("Index", "Home", new { area = "" });
        }
        return Redirect("/Account/WrongPassword");
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home", new { area = "" });
    }
    
    public IActionResult AccessDenied()
    {
        return View();
    }

    public IActionResult WrongPassword()
    {
        return View();
    }
}
