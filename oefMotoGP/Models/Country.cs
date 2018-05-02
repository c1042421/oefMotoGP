using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oefMotoGP.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }

        public List<Ticket> Tickets { get; set; }
        public List<Rider> Riders { get; set; }
    }
}
