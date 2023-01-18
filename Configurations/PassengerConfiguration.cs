using Marcel_Socolan_Proiect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marcel_Socolan_Proiect.Configurations;

public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
{
    public void Configure(EntityTypeBuilder<Passenger> builder)
    {
        // Data cu care se va face seed la tabelul cu passengers
        builder.HasData(
            new Passenger
            {
                Id = new Guid("3da33c62-67e4-4764-9a7e-6ce322b92b92"),
                FirstName = "Pasager",
                LastName = "1",
                IdentityCode = "B1234",
                Age = 25,
            },
            new Passenger
            {
                Id = new Guid("98d9b24e-f89c-4a22-bb7f-2ba26a896bbf"),
                FirstName = "Pasager",
                LastName = "2",
                IdentityCode = "B4321",
                Age = 31
            }
        );
    }
}
