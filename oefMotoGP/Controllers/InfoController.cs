using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using oefMotoGP.Models;
using oefMotoGP.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oefMotoGP.Controllers
{
    public class InfoController : Controller
    {
        private readonly GPContext _context;

        public InfoController(GPContext context) {
            _context = context;
        }

        public IActionResult ListRaces()
        {
            ViewData["bannerNaam"] = "bannerRaces.jpg";
            ViewData["pageTitle"] = "Races";

            List<IGrouping<string, Race>> racesByDate = _context.Races.OrderBy(race => race.Date).GroupBy(race => race.Date.ToString("MMMM")).ToList();

            return View(racesByDate);
        }

        public IActionResult SelectRace(SelectRaceViewModel model)
        {
            ViewData["bannerNaam"] = "bannerRaces.jpg";
            ViewData["pageTitle"] = "Races";

            List<Race> races = _context.Races.OrderBy(r => r.Name).ToList();
            Race selectedRace = _context.Races.Where(r => r.RaceID == model.RaceID).SingleOrDefault();

            SelectList selectRacesList = new SelectList(races, "RaceID", "Name", model.RaceID);

            SelectRaceViewModel vm = new SelectRaceViewModel();

            vm.Races = selectRacesList;
            vm.SelectedRace = selectedRace;
    
            return View(vm);
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

            List<Rider> riders = _context.Riders.OrderBy(r => r.Number).ToList();

            return View(riders);
        }

        public IActionResult BuildMap() {
            ViewData["pageTitle"] = "Races on map";
            ViewData["bannerNaam"] = "bannerRaces.jpg";

            List<Race> races = _context.Races.ToList();

            return View(races);
        }

        public IActionResult ShowRace(int id)
        {
            ViewData["bannerNaam"] = "bannerRaces.jpg";
            Race race = _context.Races.Where(r=> r.RaceID == id).FirstOrDefault();
            
            return View(race);
        }
    }
}
