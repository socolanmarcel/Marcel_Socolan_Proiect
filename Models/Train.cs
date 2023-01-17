namespace Marcel_Socolan_Proiect.Models;

public class Train
{
    public int Id { get; set; }
    public int Speed  { get; set; }
    public long Capacity { get; set; }
    // Fiecare tren are un conductor responsabil.
    public Conductor ResponsibleConductor { get; set; }

    // Un tren are multe rute pe zi.
    public ICollection<Route> Routes { get; set; }
}
