using System.Numerics;

namespace SBS_NBA_DavTest.Models
{
    public class NBATeam
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string Stadium { get; set; }
        public string Logo { get; set; }
        public string URL { get; set; }



        // Navigation property for players in this team
        public ICollection<Player> Players { get; set; }
    }


}
