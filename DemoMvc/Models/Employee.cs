using System.IO;
using System.Security.AccessControl;
using System;
using DemoMvc.Models;
using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh.Models;
    public class Employee : Person 
{
    [Key]
    public string EmployeeID {get; set;}
    public int Age {get; set;}
    
}