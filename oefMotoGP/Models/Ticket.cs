﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace oefMotoGP.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public int RaceID { get; set; }

        public int Number { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Paid { get; set; }
        public Race Race { get; set; }

        public Country Country { get; set; }
    }
}