using Microsoft.AspNetCore.Mvc;
using MyFirstASPNetWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNetWebApp.Controllers
{
    public class subController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]

        public IActionResult CalculateGrade ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateGrade(CalculateGradeModel model)
        {
            return View();
        }
    }
}
