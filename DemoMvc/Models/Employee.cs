using System.IO;
using System.Security.AccessControl;
using System;
using DemoMvc.Models;
namespace BaiThucHanh.Models;
    public class Employee : Person 
{
    public string EmployeeID {get; set;}
    public int Age {get; set;}
    
}