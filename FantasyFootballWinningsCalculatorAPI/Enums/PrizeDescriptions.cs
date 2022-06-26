using System.ComponentModel;

namespace FantasyFootballWinningsCalculatorAPI.Enums
{
    public enum PrizeDescriptions
    {
        [Description("Per Win")]
        Win,
        [Description("Division Winnder")]
        DivisionWinner,
        [Description("First Round Playoffs")]
        FirstRoundPlayoff,
        [Description("Second Round Playoffs")]
        SecondRoundPlayoff,
        [Description("Superbowl Loser")]
        SuperbowlLoser,
        [Description("Superbowl Winner")]
        SuperbowlWinner,
        [Description("Top QB")]
        TopQB,
        [Description("Top RB")]
        TopRB,
        [Description("Top WR")]
        TopWR,
        [Description("Top TE")]
        TopTE,
        [Description("Top D/ST")]
        TopDST,
        [Description("Top K")]
        TopK
    }
}
