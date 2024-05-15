

using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers;

public class PersonController : Controller
{
     public async Task<IActionResult> Upload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if(file!= null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    ModelState.AddModelError("", "Please choose excel file to upload");
                }
                else
                {
                    var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        var dt =_excelProcess.ExcelToDataTable(fileLocation);
                        for (int i = 0;i < dt.Rows.Count;i++)
                        {
                            var ps = new Person();
                            ps.PersonID = dt.Rows[i][0].ToString();
                            ps.FullName = dt.Rows[i][1].ToString();
                            ps.Address = dt.Rows[i][2].ToString();
                            _context.Add(ps);
                        }
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View();
}

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