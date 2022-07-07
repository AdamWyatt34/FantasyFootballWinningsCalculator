import React from "react";
import { TeamStatsViewModel } from "../models/team-stats-view-model";

interface TeamWinningsProps {
  Winnings: TeamStatsViewModel;
}

function TeamWinnings(props: TeamWinningsProps) {
  const fullDescriptions = props.Winnings.fullPrizeDescriptions;
  let totalSum: number = 0;

  fullDescriptions.forEach((fpd) => {
    totalSum += fpd.winnings;
  });

  return (
    <div>
      <table className="table table-sm mt-3">
        <thead className="table-dark">
          <tr>
            <th>Description</th>
            <th>Amount</th>
          </tr>
        </thead>
        <tbody className="table-group-divider">
          {fullDescriptions?.length > 0 ? (
            fullDescriptions?.map((prize, index) => (
              <tr key={index + "-" + prize.prizeDescription}>
                <td>{prize.description}</td>
                <td>{prize.winnings}</td>
              </tr>
            ))
          ) : (
            <tr>
              <td></td>
            </tr>
          )}
        </tbody>
        <tfoot>
          <tr key={"foot"}>
            <td>Total</td>
            <td>{totalSum}</td>
          </tr>
        </tfoot>
      </table>
    </div>
  );
}

export default TeamWinnings;
