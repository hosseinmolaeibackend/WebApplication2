using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Areas.Users.Controllers;

[Area("Users")]
[Authorize]
public class UserBaseController : Controller
{
}