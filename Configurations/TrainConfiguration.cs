using Marcel_Socolan_Proiect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marcel_Socolan_Proiect.Configurations;

public class TrainConfiguration : IEntityTypeConfiguration<Train>
{
    public void Configure(EntityTypeBuilder<Train> builder)
    {
        // Data cu care se va face seed la tabelul cu trains
        builder.HasData(
            new Train
            {
                Id = 1,
                Speed = 120,
                Capacity = 75,
                ResponsibleConductorId = new Guid("c46a393d-daff-464f-8cb8-04cb8653f7c7")
            
            },
            new Train
            {
                Id = 2,
                Speed = 115,
                Capacity = 60,
                ResponsibleConductorId = new Guid("69d6f1b7-2864-4d24-a7e2-4ed3eec972b7")
            }
        );
    }
}