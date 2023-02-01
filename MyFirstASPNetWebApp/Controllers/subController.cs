using Microsoft.AspNetCore.Mvc;
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
    }
}
