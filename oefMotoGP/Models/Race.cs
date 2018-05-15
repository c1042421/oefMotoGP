using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace oefMotoGP.Models
{
    public class Race
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RaceID { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string Description { get; set; }

        public int Length { get; set; }

        public DateTime Date { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}
