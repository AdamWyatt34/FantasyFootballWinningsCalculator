namespace FantasyFootballWinningsCalculatorAPI.Options
{
    public interface IAPIOptions
    {
        string CurrentPath { get; set; }
        string Espn_S2Cookie { get; set; }
        string HistoricalPath { get; set; }
        string LeagueId { get; set; }
        string RosterViewName { get; set; }
        string SWIDCookie { get; set; }
        string TeamViewName { get; set; }
    }
}