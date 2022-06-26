namespace FantasyFootballWinningsCalculatorAPI.Options
{
    public class APIOptions : IAPIOptions
    {
        public string CurrentPath { get; set; }
        public string HistoricalPath { get; set; }
        public string SWIDCookie { get; set; }
        public string Espn_S2Cookie { get; set; }
        public string LeagueId { get; set; }
        public string RosterViewName { get; set; }
        public string TeamViewName { get; set; }
    }
}
