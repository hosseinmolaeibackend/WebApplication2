using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class ArticleController : Controller
{
   [Route("faqs")]
    public IActionResult FAQS()
    {
        return View();
    }

    public string ShowResponseQusetion(int idQs)
    {
        return "hello";
    }
}