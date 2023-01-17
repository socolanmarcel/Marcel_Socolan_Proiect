using Marcel_Socolan_Proiect.Models;
using Microsoft.EntityFrameworkCore;

namespace Marcel_Socolan_Proiect.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    public DbSet<Train> Trains { get; set; }
    public DbSet<Marcel_Socolan_Proiect.Models.Route> Routes { get; set; }
    public DbSet<Passenger> Passengers { get; set; }
    public DbSet<Conductor> Conductors { get; set; }
}
