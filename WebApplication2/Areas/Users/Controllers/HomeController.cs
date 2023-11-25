using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.ContextHelper;

namespace WebApplication2.Areas.Users.Controllers;

[Area("Users")]
[Authorize]
public class HomeController : UserBaseController
{
    // GET
    
    public IActionResult Index()
    {
        var userId = User.GetUserId();
        var userEmail = User.GetUserEmail();
        ViewBag.userid = userId;
        ViewBag.useremail = userEmail;
        return View();
    }
}