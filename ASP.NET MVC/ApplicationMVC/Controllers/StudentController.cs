﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ApplicationMVC.Controllers
{
    public class StudentController : Controller
    {
        // 
        // GET: /Student/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /Student/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
