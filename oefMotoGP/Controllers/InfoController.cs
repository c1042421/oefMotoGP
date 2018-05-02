using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using oefMotoGP.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oefMotoGP.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult ListRaces()
        {
            ViewData["bannerNaam"] = "bannerRaces.jpg";
            ViewData["pageTitle"] = "Races";
            return View();
        }

        public IActionResult ListTeams(){
            ViewData["bannerNaam"] = "bannerTeams.jpg";
            ViewData["pageTitle"] = "Teams";
            return View();
        }

        public IActionResult ListRiders()
        {
            ViewData["bannerNaam"] = "bannerRiders.jpg";
            ViewData["pageTitle"] = "Riders";
            return View();
        }

        public IActionResult BuildMap() {
            ViewData["pageTitle"] = "Races on map";
            ViewData["bannerNaam"] = "bannerRaces.jpg";

            List<Race> races = new List<Race>();
            races.Add(new Race()
            {
                RaceID = 1,
                X = 515,
                Y = 19,
                Name = "Assen"
            });
            races.Add(new Race()
            {
                RaceID = 2,
                X = 859,
                Y = 249,
                Name = "Losail Circuit"
            });
            races.Add(new Race()
            {
                RaceID = 3,
                X = 194,
                Y = 428,
                Name = "Autodromo Termas de Rio Hondo"
            });
            ViewData["races"] = races;
            return View();
        }
    }
}
