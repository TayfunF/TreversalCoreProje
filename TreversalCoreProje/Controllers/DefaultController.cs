﻿using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
