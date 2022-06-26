namespace FantasyFootballWinningsCalculatorAPI.Models.Teams
{
    public class Away
    {
        public double gamesBack { get; set; }
        public int losses { get; set; }
        public double percentage { get; set; }
        public double pointsAgainst { get; set; }
        public double pointsFor { get; set; }
        public int streakLength { get; set; }
        public string streakType { get; set; }
        public int ties { get; set; }
        public int wins { get; set; }
    }

}
