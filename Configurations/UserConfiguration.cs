using Marcel_Socolan_Proiect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marcel_Socolan_Proiect.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        // Data cu care se va face seed la tabelul cu utilizatori
        builder.HasData(
            new UserModel
            {
                Id = 1,
                Username = "admin1",
                Password = "a1234",
                Role = "admin"
            },
            new UserModel
            {
                Id = 2,
                Username = "admin2",
                Password = "a1234",
                Role = "admin"
            },
            new UserModel
            {
                Id = 3,
                Username = "utilizator1",
                Password = "u1234",
                Role = "user"
            },
            new UserModel
            {
                Id = 4,
                Username = "utilizator2",
                Password = "u1234",
                Role = "user"
            }
        );
    }
}