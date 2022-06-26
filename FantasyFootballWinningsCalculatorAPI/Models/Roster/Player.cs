namespace FantasyFootballWinningsCalculatorAPI.Models.Roster
{
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

}
