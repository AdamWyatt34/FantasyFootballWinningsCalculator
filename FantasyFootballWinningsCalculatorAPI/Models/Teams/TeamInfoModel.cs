namespace FantasyFootballWinningsCalculatorAPI.Models.Teams
{
    public class TeamInfoModel
    {
        public DraftDetail draftDetail { get; set; }
        public int gameId { get; set; }
        public int id { get; set; }
        public List<Member> members { get; set; }
        public int scoringPeriodId { get; set; }
        public int seasonId { get; set; }
        public int segmentId { get; set; }
        public Status status { get; set; }
        public List<Team> teams { get; set; }
    }
}
