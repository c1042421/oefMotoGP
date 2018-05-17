using Microsoft.AspNetCore.Mvc.Rendering;
using oefMotoGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oefMotoGP.ViewModel
{
    public class ListTicketsViewModel
    {
        public SelectList Races { get; set; }
        public int? RaceID { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
