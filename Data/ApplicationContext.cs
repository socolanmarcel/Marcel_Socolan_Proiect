using Marcel_Socolan_Proiect.Configurations;
using Marcel_Socolan_Proiect.Models;
using Microsoft.EntityFrameworkCore;

namespace Marcel_Socolan_Proiect.Data;

public class ApplicationContext : DbContext
{
    public DbSet<Train> Trains { get; set; }
    public DbSet<Marcel_Socolan_Proiect.Models.Route> Routes { get; set; }
    public DbSet<Passenger> Passengers { get; set; }
    public DbSet<Conductor> Conductors { get; set; }
    public DbSet<UserModel> Users { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new ConductorConfiguration());
        builder.ApplyConfiguration(new PassengerConfiguration());
        builder.ApplyConfiguration(new TrainConfiguration());
    }
}
