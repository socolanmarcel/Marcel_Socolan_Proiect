using Marcel_Socolan_Proiect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marcel_Socolan_Proiect.Configurations;

public class ConductorConfiguration : IEntityTypeConfiguration<Conductor>
{
    public void Configure(EntityTypeBuilder<Conductor> builder)
    {
        // Data cu care se va face seed la tabelul cu cunductors
        builder.HasData(
            new Conductor
            {
                Id = new Guid("c46a393d-daff-464f-8cb8-04cb8653f7c7"),
                FirstName = "Ion",
                LastName = "Ionescu",
                EmployeeCode = "1234",
                WorkingHoursPerDay = 8,
                Address = "O adresa"
            },
            new Conductor
            {
                Id = new Guid("69d6f1b7-2864-4d24-a7e2-4ed3eec972b7"),
                FirstName = "Mihai",
                LastName = "Mihailescu",
                EmployeeCode = "4321",
                WorkingHoursPerDay = 7,
                Address = "Alta adresa"
            }
        );
    }
}