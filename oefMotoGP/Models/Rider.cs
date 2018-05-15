using System.ComponentModel.DataAnnotations.Schema;

namespace oefMotoGP.Models
{
    public class Rider
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RiderID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string FullName { get => FirstName + " " + LastName; }

        public int CountryID { get; set; }

        public int TeamID { get; set; }

        public string Bike { get; set; }

        public int Number { get; set; }
    }
}