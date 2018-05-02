using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oefMotoGP.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult OrderTicket()
        {
            ViewData["bannerNaam"] = "bannerTickets.jpg";
            ViewData["pageTitle"] = "Order Tickets";
            return View();
        }

        public IActionResult ConfirmOrder()
        {
            ViewData["bannerNaam"] = "bannerTickets.jpg";
            ViewData["pageTitle"] = "Confirmation";
            return View();
        }
    }
}
