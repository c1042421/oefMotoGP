using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace oefMotoGP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            int bannerID = new Random().Next(1, 5);
            ViewData["bannerNaam"] = "banner" + bannerID + ".jpg";
            return View();
        }
    }
}
