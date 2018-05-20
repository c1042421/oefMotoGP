using oefMotoGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oefMotoGP.ViewModel
{
    public class ListTeamRidersViewModel
    {
        public List<Team> Teams { get; set; }
        public Team SelectedTeam { get; set; }
        public int TeamID { get; set; }
    }
}
