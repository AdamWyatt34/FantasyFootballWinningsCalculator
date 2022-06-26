namespace FantasyFootballWinningsCalculatorAPI.Options
{
    public class WinningsOptions : IWinningsOptions
    {
        public int TotalPayout { get; set; }
        public double PerWin { get; set; }
        public double DivisionWinner { get; set; }
        public double FirstRoundPlayoffs { get; set; }
        public double SecondRoundPlayoffs { get; set; }
        public double SuperbowlLoser { get; set; }
        public double SuperbowlWinner { get; set; }
        public double TopQB { get; set; }
        public double TopRB { get; set; }
        public double TopWR { get; set; }
        public double TopTE { get; set; }
        public double TopDST { get; set; }
        public double TopK { get; set; }
        public int MinimumNonSuperbowl { get; set; }
        public int MaximumNonSuperbowl { get; set; }
    }
}
