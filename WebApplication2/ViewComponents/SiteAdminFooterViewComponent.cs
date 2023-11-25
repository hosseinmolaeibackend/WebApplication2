using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents;

public class SiteAdminFooterViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("SiteAdminFooter");
    }
}