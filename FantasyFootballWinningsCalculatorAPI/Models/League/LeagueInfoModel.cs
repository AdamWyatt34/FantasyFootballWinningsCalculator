﻿using FantasyFootballWinningsCalculatorAPI.Models.Teams;

namespace FantasyFootballWinningsCalculatorAPI.Models.League
{
    public class LeagueInfoModel
    {
        public int gameId { get; set; }
        public int id { get; set; }
        public List<Member> members { get; set; }
        public int scoringPeriodId { get; set; }
        public int seasonId { get; set; }
        public int segmentId { get; set; }
        public Settings settings { get; set; }
        public Status status { get; set; }
        public List<Team> teams { get; set; }
    }

    public class Member
    {
        public string displayName { get; set; }
        public string id { get; set; }
        public bool isLeagueManager { get; set; }
    }

    public class Settings
    {
        public string name { get; set; }
    }

    public class Status
    {
        public int currentMatchupPeriod { get; set; }
        public bool isActive { get; set; }
        public int latestScoringPeriod { get; set; }
    }
}
