using Marcel_Socolan_Proiect.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adaugam baza de date in containerul DI.
builder.Services.AddDbContext<ApplicationContext>(opt =>
{
    opt.UseSqlite("Data Source=Database.db");
});

// Adaugam serviciu de autentificare.
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, opt =>
{
    opt.Cookie.Name = CookieAuthenticationDefaults.AuthenticationScheme;
    opt.LoginPath = "/account/login";
    opt.AccessDeniedPath = "/account/accessdenied";
});

builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy("AdminOnly", policy => policy.RequireClaim("Admin"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
