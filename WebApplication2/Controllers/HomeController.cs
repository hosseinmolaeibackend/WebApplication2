﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }
}