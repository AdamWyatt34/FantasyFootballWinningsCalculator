import { FullPrizeDescription } from "./full-prize-descriptions";
import { Team } from "./team";

export interface TeamStatsViewModel {
  team: Team;
  fullPrizeDescriptions: FullPrizeDescription[];
}
