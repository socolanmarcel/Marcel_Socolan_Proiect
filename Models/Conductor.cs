using System.ComponentModel.DataAnnotations;

namespace Marcel_Socolan_Proiect.Models;

public class Conductor
{
    [Key]
    public Guid Id { get; set; }
    [Display(Name = "Prenume")]
    public string FirstName { get; set; }
    [Display(Name = "Nume")]
    public string LastName { get; set; }
    [Display(Name = "Cod de lucru")]
    public string EmployeeCode { get; set; }
    [Display(Name = "Ore de lucru pe zi")]
    public int WorkingHoursPerDay { get; set; }
    [Display(Name = "Adresa")]
    public string Address { get; set; }
}
