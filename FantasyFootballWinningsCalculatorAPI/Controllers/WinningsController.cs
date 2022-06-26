using FantasyFootballWinningsCalculatorAPI.Models.Teams;
using FantasyFootballWinningsCalculator.ViewModels;
using FantasyFootballWinningsCalculatorAPI.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Net;
using FantasyFootballWinningsCalculatorAPI.Enums;
using FantasyFootballWinningsCalculatorAPI.Models;
using FantasyFootballWinningsCalculatorAPI.Models.Players;
using FantasyFootballWinningsCalculatorAPI.Services;
using FantasyFootballWinningsCalculatorAPI.Models.Roster;

namespace FantasyFootballWinningsCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinningsController : ControllerBase
    {
        private readonly APIOptions _options;
        private readonly WinningsOptions _winningsOptions;

        public WinningsController(IOptions<APIOptions> options, IOptions<WinningsOptions> winningsOptions)
        {
            _options = options.Value;
            _winningsOptions = winningsOptions.Value;
        }

        //Get Data
        [HttpGet]
        [Route("{teamId}/{year}/{isHistorical}")]
        public async Task<TeamStatsViewModel> GetWinningsByTeam(int teamId, int year, bool isHistorical)
        {
            var path = isHistorical ? _options.HistoricalPath : _options.CurrentPath;

            var teamInfoUrl = $"{path}/{_options.LeagueId}?seasonId={year}&view={_options.TeamViewName}&forTeamId={teamId}";
            var rosterInfoUrl = $"{path}/{_options.LeagueId}?seasonId={year}&view={_options.RosterViewName}&forTeamId={teamId}";

            var teamInfo = await EspnHttpClientService<TeamInfoModel>.GetDataFromEspn(teamInfoUrl, _options);
            var rosterInfo = await EspnHttpClientService<RosterInfoModel>.GetDataFromEspn(rosterInfoUrl, _options);

            return TeamStatsViewModelService.CalculateStats(_winningsOptions, teamInfo.First(), rosterInfo.First());
            
        }
    }
}
