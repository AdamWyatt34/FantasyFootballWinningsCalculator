using FantasyFootballWinningsCalculator.ViewModels;
using FantasyFootballWinningsCalculatorAPI.Enums;
using FantasyFootballWinningsCalculatorAPI.Extensions;
using FantasyFootballWinningsCalculatorAPI.Models.Roster;
using FantasyFootballWinningsCalculatorAPI.Models.Teams;
using FantasyFootballWinningsCalculatorAPI.Options;

namespace FantasyFootballWinningsCalculatorAPI.Services
{
    public static class TeamStatsViewModelService
    {
        public static TeamStatsViewModel CalculateStats(WinningsOptions options, TeamInfoModel teamInfo, RosterInfoModel rosterInfo)
        {
            var output = new TeamStatsViewModel();
            var team = teamInfo.teams.First();
            output.Team = team;

            var totalPayout = options.TotalPayout;

            //First calculate wins
            var totalWins = team.record.overall.wins;
            output.FullPrizeDescriptions.Add(CreateFullPrizeDescription(
                PrizeDescriptions.Win,
                $"Won {totalWins} games",
                totalWins * (totalPayout * options.PerWin)));

            //Then if Division Winner
            var divisionGamesBack = team.record.division.gamesBack;
            if (divisionGamesBack == 0)
            {
                output.FullPrizeDescriptions.Add(CreateFullPrizeDescription(
                    PrizeDescriptions.DivisionWinner,
                    $"Division Winner",
                    totalPayout * options.DivisionWinner));
            }

            //1st check if playoff seed is less than or equal to minimum
            var finalPlacement = team.rankCalculatedFinal;
            if (finalPlacement <= options.MinimumNonSuperbowl)
            {
                output.FullPrizeDescriptions.Add(CreateFullPrizeDescription(
                    PrizeDescriptions.FirstRoundPlayoff,
                    $"Made it to 1st round playoffs",
                    totalPayout * options.FirstRoundPlayoffs));
            }

            //2nd round check if final placement is between max and min non superbowl
            if (finalPlacement != 0 && finalPlacement >= options.MaximumNonSuperbowl && finalPlacement <= options.MinimumNonSuperbowl)
            {
                output.FullPrizeDescriptions.Add(CreateFullPrizeDescription(
                   PrizeDescriptions.SecondRoundPlayoff,
                   $"Made it to @nd round playoffs",
                   totalPayout * options.SecondRoundPlayoffs));
            }

            switch (finalPlacement)
            {
                //Then superbowl placement (loser or winner) check if final placement is 2nd or 1st 
                //superbowl loser
                case 2:
                    output.FullPrizeDescriptions.Add(CreateFullPrizeDescription(
                        PrizeDescriptions.SuperbowlLoser,
                        $"Lost in the Superbowl",
                        totalPayout * options.SuperbowlLoser));
                    break;
                case 1:
                    output.FullPrizeDescriptions.Add(CreateFullPrizeDescription(
                        PrizeDescriptions.SuperbowlLoser,
                        $"Superbowl Winner",
                        totalPayout * options.SuperbowlWinner));
                    break;
            }

            //Then top position players
            //Check roster for any players with position ranking of 1.
            var players = rosterInfo.teams.First().roster.entries.Where(e => e.playerPoolEntry.ratings._0.positionalRanking == 1);
            var positionToWinningsMap = new Dictionary<Positions, PrizeDescriptions>()
            {
                {Positions.QB, PrizeDescriptions.TopQB },
                {Positions.RB, PrizeDescriptions.TopRB },
                {Positions.WR, PrizeDescriptions.TopWR },
                {Positions.TE, PrizeDescriptions.TopTE },
                {Positions.DST, PrizeDescriptions.TopDST },
                {Positions.K, PrizeDescriptions.TopK }
            };

            var prizeDescriptionToValueMap = new Dictionary<PrizeDescriptions, double>()
            {
                { PrizeDescriptions.TopQB, options.TopQB },
                { PrizeDescriptions.TopRB, options.TopRB },
                { PrizeDescriptions.TopWR, options.TopWR },
                { PrizeDescriptions.TopTE, options.TopTE },
                { PrizeDescriptions.TopDST, options.TopDST },
                { PrizeDescriptions.TopK, options.TopK },
            };

            if (players.Any())
            {
                players.ToList().ForEach(p =>
                {
                    var description = positionToWinningsMap.GetValueOrDefault(
                        (Positions)p.playerPoolEntry.player.defaultPositionId,
                        PrizeDescriptions.Win);

                    var value = prizeDescriptionToValueMap.GetValueOrDefault(description);

                    output.FullPrizeDescriptions.Add(CreateFullPrizeDescription(
                   description,
                   $"{description.ToDescription()}",
                   value * totalPayout));
                });
            }

            return output;
        }

        private static FullPrizeDescriptions CreateFullPrizeDescription(PrizeDescriptions prizeDescriptions, string description, double winnings)
        {
            return new FullPrizeDescriptions()
            {
                PrizeDescriptions = prizeDescriptions,
                Description = description,
                Winnings = winnings
            };
        }
    }
}
