using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents;

public class SiteAdminHeaderViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("SiteAdminHeader");
    }
}