namespace FantasyFootballWinningsCalculatorAPI.Models.Roster
{
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

}
