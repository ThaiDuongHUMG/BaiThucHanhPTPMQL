using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models;
[Table("People")]
public class Person
{
  
  
  public string PersonID { get; set; }
  public string FullName { get; set; }
  public string Address { get; set; }

  public int Age{ get; set; }
  
  
  
  
}