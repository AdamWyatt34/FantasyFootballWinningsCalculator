using FantasyFootballWinningsCalculatorAPI.Enums;
using FantasyFootballWinningsCalculatorAPI.Models.Teams;
using FantasyFootballWinningsCalculatorAPI.Options;
using Microsoft.Extensions.Options;

namespace FantasyFootballWinningsCalculator.ViewModels
{
    public class TeamStatsViewModel
    {
        public Team Team { get; set; }
        //public Dictionary<PrizeDescriptions, (string, double)> Winnings { get; set; } = new Dictionary<PrizeDescriptions, (string, double)>();

        public List<FullPrizeDescriptions> FullPrizeDescriptions { get; set; } = new List<FullPrizeDescriptions>();
    }

    public class FullPrizeDescriptions
    {
        public PrizeDescriptions PrizeDescriptions { get; set; }
        public string Description { get; set; }
        public double Winnings { get; set; }
    }
}
