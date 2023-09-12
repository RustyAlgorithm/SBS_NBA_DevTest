namespace SBS_NBA_DavTest.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }

        // Navigation property for teams this player belongs to
        public ICollection<NBATeam> Teams { get; set; }
    }

}
