using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models;
[Table("Persons")]
public class  Person
{
    [Key]
    public string PersonID {get; set;}
    public string FullName {get; set;}
    [Required]
    public string? Address {get; set;}
}