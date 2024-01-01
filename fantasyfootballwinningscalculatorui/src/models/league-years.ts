export interface LeagueYears {
  year: number;
  isHistorical: boolean;
}

export function currentYears(): LeagueYears[] {
  return [
    { year: 2021, isHistorical: true },
    { year: 2022, isHistorical: true },
    { year: 2023, isHistorical: false },
  ];
}
