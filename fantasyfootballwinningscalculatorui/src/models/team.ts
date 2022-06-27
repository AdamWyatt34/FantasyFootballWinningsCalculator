export interface Team {
    abbrev: string;
    currentProjectedRank: number;
    divisionId: number;
    draftDayProjectedRank: number;
    id: number;
    isActive: boolean;
    location: string;
    logo: string;
    logoType: string;
    nickname: string;
    owners: string[];
    playoffSeed: number;
    points: number;
    pointsAdjusted: number;
    pointsDelta: number;
    primaryOwner: string;
    rankCalculatedFinal: number;
    rankFinal: number;
    record: Record;
    waiverRank: number;
    watchList: number[];
}

export interface Record {
    away: RecordInfo;
    division: RecordInfo;
    home: RecordInfo;
    overall: RecordInfo;
}

export interface Away {

}

interface RecordInfo {
    gamesBack: number;
    losses: number;
    percentage: number;
    pointsAgainst: number;
    pointsFor: number;
    streakLength: number;
    streakType: string;
    ties: number;
    wins: number;
}