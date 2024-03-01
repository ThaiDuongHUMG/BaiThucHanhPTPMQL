
using System;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace DemoMvc.Controllers
{
    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
         public IActionResult Index(string fullname) 

         {
            String strResult = "Xin Chao" + fullname;
            ViewBag.info = strResult;
            return View();
            
         }

        // GET: /HelloWorld/Welcome/ 

    }
}
