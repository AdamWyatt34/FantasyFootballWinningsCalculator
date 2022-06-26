namespace FantasyFootballWinningsCalculatorAPI.Models.Roster
{
    public class Status
    {
        public long activatedDate { get; set; }
        public int createdAsLeagueType { get; set; }
        public int currentLeagueType { get; set; }
        public int currentMatchupPeriod { get; set; }
        public int finalScoringPeriod { get; set; }
        public int firstScoringPeriod { get; set; }
        public bool isActive { get; set; }
        public bool isExpired { get; set; }
        public bool isFull { get; set; }
        public bool isPlayoffMatchupEdited { get; set; }
        public bool isToBeDeleted { get; set; }
        public bool isViewable { get; set; }
        public bool isWaiverOrderEdited { get; set; }
        public int latestScoringPeriod { get; set; }
        public List<object> previousSeasons { get; set; }
        public long standingsUpdateDate { get; set; }
        public int teamsJoined { get; set; }
        public int transactionScoringPeriod { get; set; }
        public long waiverLastExecutionDate { get; set; }
    }

}
