﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace JosephYangViewsWausau.Controllers
{
    public class Wausau : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ThingsToDo()
        {

           
            return View();
        }

        public IActionResult AreaHotels()
        {
           
            return View();
        }

        public IActionResult ClimbRibMountain()
        {
            return View();
        }

        public IActionResult BirdWatching()
        {
            return View();
        }

    }
}
