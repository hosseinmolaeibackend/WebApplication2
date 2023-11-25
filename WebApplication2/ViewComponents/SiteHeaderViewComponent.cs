using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents;

public class SiteHeaderViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("SiteHeader");
    }
}