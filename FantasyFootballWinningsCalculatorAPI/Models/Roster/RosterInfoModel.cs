using System.Text.Json.Serialization;

namespace FantasyFootballWinningsCalculatorAPI.Models.Roster
{
    public class RosterInfoModel
    {
        public DraftDetail draftDetail { get; set; }
        public int gameId { get; set; }
        public int id { get; set; }
        public int scoringPeriodId { get; set; }
        public int seasonId { get; set; }
        public int segmentId { get; set; }
        public Status status { get; set; }
        public List<Team> teams { get; set; }
    }

    public class _0
    {
        public int positionalRanking { get; set; }
        public int totalRanking { get; set; }
        public double totalRating { get; set; }
    }

    public class DraftDetail
    {
        public bool drafted { get; set; }
        public bool inProgress { get; set; }
    }

    public class Entry
    {
        public object acquisitionDate { get; set; }
        public object acquisitionType { get; set; }
        public string injuryStatus { get; set; }
        public int lineupSlotId { get; set; }
        public object pendingTransactionIds { get; set; }
        public int playerId { get; set; }
        public PlayerPoolEntry playerPoolEntry { get; set; }
        public string status { get; set; }
    }

    public class Ownership
    {
        public double auctionValueAverage { get; set; }
        public double averageDraftPosition { get; set; }
        public double percentChange { get; set; }
        public double percentOwned { get; set; }
        public double percentStarted { get; set; }
    }

    public class Player
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
        public string lastName { get; set; }
        public Ownership ownership { get; set; }
        public int proTeamId { get; set; }
        public int universeId { get; set; }
    }

    public class PlayerPoolEntry
    {
        public double appliedStatTotal { get; set; }
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

    public class Ratings
    {
        [JsonPropertyName("0")]
        public _0 _0 { get; set; }
    }

    public class Roster
    {
        public double appliedStatTotal { get; set; }
        public List<Entry> entries { get; set; }
    }

    public class Status
    {
        public long activatedDate { get; set; }
        public int createdAsLeagueType { get; set; }
        public int currentLeagueType { get; set; }
        public int currentMatchupPeriod { get; set; }
        public int finalScoringPeriod { get; set; }
        public int firstScoringPeriod { get; set; }
        public bool isActive { get; set; }
        public bool isExpired { get; set; }
        public bool isFull { get; set; }
        public bool isPlayoffMatchupEdited { get; set; }
        public bool isToBeDeleted { get; set; }
        public bool isViewable { get; set; }
        public bool isWaiverOrderEdited { get; set; }
        public int latestScoringPeriod { get; set; }
        public List<object> previousSeasons { get; set; }
        public long standingsUpdateDate { get; set; }
        public int teamsJoined { get; set; }
        public int transactionScoringPeriod { get; set; }
        public long waiverLastExecutionDate { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public Roster roster { get; set; }
    }

}
