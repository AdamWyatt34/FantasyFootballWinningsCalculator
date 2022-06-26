namespace FantasyFootballWinningsCalculatorAPI.Models.Roster
{
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

}
