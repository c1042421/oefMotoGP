﻿using System;
using System.Collections.Generic;

namespace oefMotoGP.Models
{
    public class Race
    {
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
