namespace FantasyFootballWinningsCalculatorAPI.Models.Roster
{
    public class RosterInfoModel
    {
        public DraftDetail draftDetail { get; set; }
        public int gameId { get; set; }
        public int id { get; set; }
        public int scoringPeriodId { get; set; }
        public int seasonId { get; set; }
        public int segmentId { get; set; }
        public Status status { get; set; }
        public List<Team> teams { get; set; }
    }
}
