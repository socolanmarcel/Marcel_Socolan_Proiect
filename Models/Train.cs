using System.ComponentModel.DataAnnotations;

namespace Marcel_Socolan_Proiect.Models;

public class Train
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Viteza")]
    public int Speed  { get; set; }
    [Display(Name = "Capacitate de persoane")]
    public long Capacity { get; set; }
    // Fiecare tren are un conductor responsabil.
    public Guid ResponsibleConductorId { get; set; }
    [Display(Name = "Conductator")]
    public Conductor ResponsibleConductor { get; set; }

    // Un tren are multe rute pe zi.
    public ICollection<Route> Routes { get; set; }
}
