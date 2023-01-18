using System.ComponentModel.DataAnnotations;

namespace Marcel_Socolan_Proiect.Models;

public class UserModel
{
    [Key]
    public int Id { get; set; }

    [Required]        
    [Display(Name = "User Name")]
    public string Username { get; set; } = null!;

    [Required]        
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    // Rolul default este utilizator
    [Required]
    public string Role { get; set; } = "user";
}
