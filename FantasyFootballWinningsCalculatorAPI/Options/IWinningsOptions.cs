namespace FantasyFootballWinningsCalculatorAPI.Options
{
    public interface IWinningsOptions
    {
        double DivisionWinner { get; set; }
        double FirstRoundPlayoffs { get; set; }
        double PerWin { get; set; }
        double SecondRoundPlayoffs { get; set; }
        double SuperbowlLoser { get; set; }
        double SuperbowlWinner { get; set; }
        double TopDST { get; set; }
        double TopK { get; set; }
        double TopQB { get; set; }
        double TopRB { get; set; }
        double TopTE { get; set; }
        double TopWR { get; set; }
        int TotalPayout { get; set; }
        int MinimumNonSuperbowl { get; set; }
        int MaximumNonSuperbowl { get; set; }
    }
}