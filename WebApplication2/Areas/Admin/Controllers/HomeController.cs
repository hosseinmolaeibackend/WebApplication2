using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Areas.Admin.Controllers;

public class HomeController : AdminBaseController
{
    // GET
    public IActionResult Index()
    {
        TempData["home"] = "current";
        return View();
    }
}