﻿using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}