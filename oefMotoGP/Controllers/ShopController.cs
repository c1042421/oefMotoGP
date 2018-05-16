using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using oefMotoGP.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oefMotoGP.Controllers
{
    public class ShopController : Controller
    {
        private readonly GPContext _context;

        public ShopController(GPContext context)
        {
            _context = context;
        }

        public IActionResult ConfirmOrder(int id)
        {
            Ticket ticket = _context.Tickets.Include(x=> x.Race).Where(t => t.TicketID == id).SingleOrDefault();

            ViewData["bannerNaam"] = "bannerTickets.jpg";
            ViewData["pageTitle"] = "Confirmation";

            return View(ticket);
        }

        [HttpPost]
        public IActionResult OrderTicket(Ticket ticket)
        {
            ticket.OrderDate = DateTime.Now;

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            return RedirectToAction("ConfirmOrder", new { id = ticket.TicketID });
        }

        public IActionResult OrderTicket()
        {
            ViewData["bannerNaam"] = "bannerTickets.jpg";
            ViewData["pageTitle"] = "Order Tickets";

            List<Country> countries = _context.Countries.OrderBy(c => c.Name).ToList();
            List<Race> races = _context.Races.OrderBy(r => r.Name).ToList();

            ViewData["countries"] = countries;
            ViewData["races"] = races;

            return View();
        }
    }
}
