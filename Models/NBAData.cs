namespace SBS_NBA_DavTest.Models
{
    public class NBAData
    {
        // Team information
        public string TeamName { get; set; }
        public string Stadium { get; set; }
        public string Logo { get; set; }

        // Team statistics
        public int Played { get; set; }
        public int Won { get; set; }
        public int Lost { get; set; }
        public int PlayedHome { get; set; }
        public int PlayedAway { get; set; }
        public string BiggestWin { get; set; }
        public string BiggestLoss { get; set; }

        // Last game information
        public string LastGameStadium { get; set; }
        public DateTime LastGameDate { get; set; }

        // MVP information
        public string MVP { get; set; }
    }

}
