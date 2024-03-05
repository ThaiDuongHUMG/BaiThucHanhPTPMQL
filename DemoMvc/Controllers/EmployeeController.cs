using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers;
    public class EmployeeController : Controller
    {
         public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Hello()
    {
        return View();
    }
    }
