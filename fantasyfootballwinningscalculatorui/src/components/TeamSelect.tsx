/* eslint-disable react-hooks/exhaustive-deps */
import React, { useEffect, useState } from "react";
import SelectOption from "../common/option";
import { currentYears } from "../models/league-years";
import { Team } from "../models/team";
import { TeamStatsViewModel } from "../models/team-stats-view-model";
import httpService from "../services/http-service";
import TeamWinnings from "./TeamWinnings";

function TeamSelect() {
  const [teams, setTeams] = useState<Team[]>([]);
  const [selectedOption, setSelectedOption] = useState(1);
  const [winnings, setWinnings] = useState<TeamStatsViewModel>();
  const [selectedYear, setSelectedYear] = useState(2022);

  const years = currentYears();

  useEffect(() => {
    const getTeams = async () => {
      const isHistorical = years.find(
        (x) => x.year === selectedYear
      )?.isHistorical;
      console.log(
        `https://localhost:7027/api/teams/${selectedYear}/${isHistorical}`
      );
      const response = await httpService.get<Team[]>(
        `https://localhost:7027/api/teams/${selectedYear}/${isHistorical}`
      );
      setTeams(response.data);
    };
    getTeams();
  }, [selectedYear]);

  useEffect(() => {
    const getWinnings = async () => {
      const isHistorical = years.find(
        (x) => x.year === selectedYear
      )?.isHistorical;
      const response = await httpService.get<TeamStatsViewModel>(
        `https://localhost:7027/api/winnings/${selectedOption}/${selectedYear}/${isHistorical}`
      );
      setWinnings(response.data);
    };
    getWinnings();
  }, [selectedOption, selectedYear]);

  const handleClick = (event: React.FormEvent<HTMLSelectElement>) => {
    setSelectedOption(parseInt(event.currentTarget.value));
  };

  const handleYearClick = (event: React.FormEvent<HTMLSelectElement>) => {
    setSelectedYear(parseInt(event.currentTarget.value));
  };

  return (
    <div>
      <div>
        <label className="form-label p-4">Year:</label>
        <select
          className="mt-4 col-md-3 col-offset-2"
          onChange={handleYearClick}
          defaultValue={years[years.length - 1].year}
        >
          {years.map((year) => (
            <SelectOption
              id={year.year.toString()}
              label={year.year.toString()}
            />
          ))}
        </select>
      </div>
      <div>
        <label className="form-label p-4">Team:</label>
        <select className="mt-4 col-md-3 col-offset-2" onChange={handleClick}>
          {teams.map((team) => (
            <SelectOption
              id={team.id.toString()}
              label={team.location + " " + team.nickname}
            />
          ))}
        </select>
      </div>
      {winnings && <TeamWinnings Winnings={winnings} />}
    </div>
  );
}

export default TeamSelect;
