using System.ComponentModel.DataAnnotations;

namespace Marcel_Socolan_Proiect.Models;

public class Passenger
{
    [Key]
    public Guid Id { get; set; }
    [Display(Name = "Prenume")]
    public string FirstName { get; set; }
    [Display(Name = "Nume")]
    public string LastName { get; set; }
    [Display(Name = "Cod buletin")]
    public string IdentityCode { get; set; }
    [Display(Name = "Virsta")]
    public int Age { get; set; }
}
