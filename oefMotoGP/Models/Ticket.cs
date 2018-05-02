namespace oefMotoGP.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public int RaceID { get; set; }
        public int Number { get; set; }
        public decimal OrderDate { get; set; }
        public bool Paid { get; set; }
    }
}