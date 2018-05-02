using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oefMotoGP.Models
{
    public class Team
    {
        public int TeamID { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public List<Rider> Riders { get; set; }
    }
}
