using System.ComponentModel.DataAnnotations;

namespace Marcel_Socolan_Proiect.Models;

public class Route
{
    public Route()
    {
        Passengers = new HashSet<Passenger>();
    }

    [Key]
    public Guid Id { get; set; }
    [Display(Name = "Timpul de plecare")]
    public DateTime DepartureTime { get; set; }
    [Display(Name = "Timpul de sosire")]
    public DateTime ArrivalTime { get; set; }

    // O ruta are multi pasageri.
    public ICollection<Passenger> Passengers { get; set; }
}
