﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level1.Controllers
{
    public class categoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}