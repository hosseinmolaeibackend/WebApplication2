using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.context;
using WebApplication2.Models;
using WebApplication2.Models.User;
using WebApplication2.Utilities;
using WebApplication2.ViewModels.Account;

namespace WebApplication2.Controllers;

public class AccountController : Controller
{
    #region Constructor

    private readonly ApplicationDbContext _db;

    public AccountController(ApplicationDbContext context)
    {
        _db = context;
    }

    #endregion
    
    #region Register
    [HttpGet("Register")]
    public IActionResult Register()
    {
        if (User.Identity.IsAuthenticated==true)
        {
            return Redirect("/");
        }
        return View();
    }
  
    [HttpPost("Register")]
    public IActionResult Register(UserViewModel userViewModel)
    {
        if (ModelState.IsValid)
        {
            if (_db.UserModels.Any(u=>u.Username == userViewModel.Username))
            {
                ModelState.AddModelError("Username","این کاربر قبلا ثبت نام کرده");
                return View(userViewModel);
            }

            var newUser = new UserModel
            {
                Username = userViewModel.Username,
                Password = PasswordHelper.EncodePasswordMD5(userViewModel.Password),
                ProfileImage = ""
            };
            _db.UserModels.Add(newUser);
            _db.SaveChanges();
            // todo:send email
            TempData["SuccessMessage"] = "با موفقیت ثبت نام شدید";
            return RedirectToAction("Login");
        }
        return View(userViewModel);
    }
    #endregion

    #region Login
    [HttpGet("Login")]
    public IActionResult Login()
    {
        if (User.Identity.IsAuthenticated)
        {
            return Redirect("/");
        }
        return View();
    }
    [HttpPost("Login"),ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel loginViewModel)
    {
        if (ModelState.IsValid)
        {
            var user = _db.UserModels.SingleOrDefault(u => u.Username == loginViewModel.Username);
            if (user == null)
            {
                ModelState.AddModelError("Username","یوزر یا پسورد اشتباه است");
                return View(loginViewModel);
            }

            if (user.Password!=PasswordHelper.EncodePasswordMD5(loginViewModel.Password))
            {
                ModelState.AddModelError("Username","یوزر یا پسورد اشتباه است");
                return View(loginViewModel);
            }
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                new Claim(ClaimTypes.Email,user.Username)
            };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            AuthenticationProperties authenticationProperties = new AuthenticationProperties()
            {
                IsPersistent = loginViewModel.Remeberme
            };
            await HttpContext.SignInAsync(claimsPrincipal,authenticationProperties);
            return RedirectToAction("index","Home");
        }
        return View(loginViewModel);
    }
    

    #endregion

    #region logout

    [Route("/Logout")]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home"); 
    } 
    
    #endregion
}