using System.ComponentModel.DataAnnotations;

namespace Marcel_Socolan_Proiect.Models;

public class Route
{
    [Key]
    public Guid Id { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }

    // O ruta are multi pasageri.
    public ICollection<Passenger> Passengers { get; set; }
}
