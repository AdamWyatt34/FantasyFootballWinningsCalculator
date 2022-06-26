using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FantasyFootballWinningsCalculatorAPI.Models.Players
{
    public class PlayerInfoModel
    {
        public List<Player> players { get; set; }
    }

    public class _0
    {
        public int positionalRanking { get; set; }
        public int totalRanking { get; set; }
        public double totalRating { get; set; }
    }

    public class Ownership
    {
        public object activityLevel { get; set; }
        public double auctionValueAverage { get; set; }
        public double auctionValueAverageChange { get; set; }
        public double averageDraftPosition { get; set; }
        public double averageDraftPositionPercentChange { get; set; }
        public object date { get; set; }
        public int leagueType { get; set; }
        public double percentChange { get; set; }
        public double percentOwned { get; set; }
        public double percentStarted { get; set; }
    }

    public class Player
    {
        public int draftAuctionValue { get; set; }
        public int id { get; set; }
        public int keeperValue { get; set; }
        public int keeperValueFuture { get; set; }
        public bool lineupLocked { get; set; }
        public int onTeamId { get; set; }
        public Player player { get; set; }
        public Ratings ratings { get; set; }
        public bool rosterLocked { get; set; }
        public bool tradeLocked { get; set; }
    }

    public class PlayerInfo
    {
        public bool active { get; set; }
        public int defaultPositionId { get; set; }
        public bool droppable { get; set; }
        public List<int> eligibleSlots { get; set; }
        public string firstName { get; set; }
        public string fullName { get; set; }
        public int id { get; set; }
        public bool injured { get; set; }
        public string injuryStatus { get; set; }
        public string jersey { get; set; }
        public string lastName { get; set; }
        public Ownership ownership { get; set; }
        public int proTeamId { get; set; }
    }

    public class Ratings
    {
        //public int positionalRanking { get; set; }
        //public int totalRanking { get; set; }
        //public double totalRating { get; set; }
        [JsonPropertyName("0")]
        public _0 _0 { get; set; }
    }

    public class Root
    {
        public List<Player> players { get; set; }
    }
}
