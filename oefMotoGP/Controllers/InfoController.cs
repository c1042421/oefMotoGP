using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using oefMotoGP.Models;
using oefMotoGP.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oefMotoGP.Controllers
{
    public class InfoController : Controller
    {
        private readonly GPContext _context;

        public InfoController(GPContext context)
        {
            _context = context;
        }

        public IActionResult ListTickets(ListTicketsViewModel model)
        {
            List<Race> races = _context.Races.OrderBy(r => r.Name).ToList();

            model.Races = new SelectList(races, "RaceID", "Name");

            model.Tickets =
                model.RaceID.HasValue ?
                _context.Tickets.Include(t => t.Country).Where(t => t.RaceID == model.RaceID).ToList() :
                _context.Tickets.Include(t => t.Country).ToList();

            return View(model);
        }

        public IActionResult ListRaces()
        {
            List<IGrouping<string, Race>> racesByDate = _context.Races.OrderBy(race => race.Date).GroupBy(race => race.Date.ToString("MMMM")).ToList();

            return View(racesByDate);
        }

        public IActionResult SelectRace(SelectRaceViewModel model)
        {
            model.SelectedRace = _context.Races.Where(r => r.RaceID == model.RaceID).SingleOrDefault();

            List<Race> races = _context.Races.OrderBy(r => r.Name).ToList();
            model.Races = new SelectList(races, "RaceID", "Name", model.RaceID);

            return View(model);
        }

        public IActionResult ListTeams()
        {
            List<Team> teams = _context.Teams.Include(t=> t.Riders).OrderBy(t => t.Name).ToList();

            return View(teams);
        }

        public IActionResult ListTeamRiders(ListTeamRidersViewModel vm)
        {
            vm.Teams = _context.Teams.OrderBy(t => t.Name).ToList();

            vm.SelectedTeam = _context.Teams.Include(t => t.Riders)
                .Where(t => t.TeamID == vm.SelctedID)
                .SingleOrDefault();

            return View(vm);
        }

        public IActionResult ListRiders()
        {
            List<Rider> riders = _context.Riders.OrderBy(r => r.Number).ToList();

            return View(riders);
        }

        public IActionResult BuildMap()
        {
            List<Race> races = _context.Races.ToList();

            return View(races);
        }

        public IActionResult ShowRace(int id)
        {
            Race race = _context.Races.Where(r => r.RaceID == id).FirstOrDefault();

            return View(race);
        }
    }
}
