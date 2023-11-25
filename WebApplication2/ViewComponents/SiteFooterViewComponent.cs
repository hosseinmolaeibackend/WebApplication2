using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents;

public class SiteFooterViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("SiteFooter");
    }
}