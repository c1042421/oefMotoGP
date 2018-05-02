namespace oefMotoGP.Models
{
    public class Rider
    {
        public int RiderID { get; set; }

        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public int CountryID { get; set; }

        public int TeamID { get; set; }

        public string Bike { get; set; }

        public int Number { get; set; }
    }
}