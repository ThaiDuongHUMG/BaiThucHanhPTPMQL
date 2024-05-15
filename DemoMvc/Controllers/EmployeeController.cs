    using BaiThucHanh.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers;
    public class EmployeeController : Controller
    {
         public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Employee emp)
    {
        string strResult = "Xin chao" + emp.EmployeeID + "-" + emp.Age + "tuoi" ;
    ViewBag.ThaiDuong =  strResult;
    return View();
    }

    }
