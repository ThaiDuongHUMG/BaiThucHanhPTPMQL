

using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers;

public class PersonController : Controller
{
    public IActionResult Index()
{
        return View ();
}
       public IActionResult Privacy()
{
          return View ();
}    
[HttpPost]
public IActionResult Privacy(Person ps)
{
    string strResult = "Xin chao" + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
    ViewBag.HienThi =  strResult;
    return View();
}

}