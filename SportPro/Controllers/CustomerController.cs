﻿using Microsoft.AspNetCore.Mvc;

namespace SportPro.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
