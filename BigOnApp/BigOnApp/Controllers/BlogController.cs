﻿using Microsoft.AspNetCore.Mvc;

namespace BigOnApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogDetail()
        {
            return View();
        }
    }
}
