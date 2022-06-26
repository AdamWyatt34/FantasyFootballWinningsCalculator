namespace FantasyFootballWinningsCalculatorAPI.Models.Teams
{
    public class Team
    {
        public string abbrev { get; set; }
        public int currentProjectedRank { get; set; }
        public int divisionId { get; set; }
        public int draftDayProjectedRank { get; set; }
        public int id { get; set; }
        public bool isActive { get; set; }
        public string location { get; set; }
        public string logo { get; set; }
        public string logoType { get; set; }
        public string nickname { get; set; }
        public List<string> owners { get; set; }
        public int playoffSeed { get; set; }
        public double points { get; set; }
        public double pointsAdjusted { get; set; }
        public double pointsDelta { get; set; }
        public string primaryOwner { get; set; }
        public int rankCalculatedFinal { get; set; }
        public int rankFinal { get; set; }
        public Record record { get; set; }
        //public TransactionCounter transactionCounter { get; set; }
        //public ValuesByStat valuesByStat { get; set; }
        public int waiverRank { get; set; }
        public List<int> watchList { get; set; }
    }

}
