namespace SBS_NBA_DavTest.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }
        public DateTime GameDateTime { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public int MVPPlayerID { get; set; }

        // Navigation properties for teams and MVP player
        public NBATeam HomeTeam { get; set; }
        public NBATeam AwayTeam { get; set; }
        public Player MVPPlayer { get; set; }
    }

}
