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
            var path = isHistorical ? _options.HistoricalPath : $"{ _options.CurrentPath}/{year}/segments/0/leagues";

            var teamInfoUrl = $"{path}/{_options.LeagueId}?seasonId={year}&view={_options.TeamViewName}&forTeamId={teamId}";
            var rosterInfoUrl = $"{path}/{_options.LeagueId}?seasonId={year}&view={_options.RosterViewName}&forTeamId={teamId}";

            TeamInfoModel teamInfo;
            RosterInfoModel rosterInfo;

            if (isHistorical)
            {
                teamInfo = (await EspnHttpClientService<List<TeamInfoModel>>.GetDataFromEspn(teamInfoUrl, _options)).First();
                rosterInfo = (await EspnHttpClientService<List<RosterInfoModel>>.GetDataFromEspn(rosterInfoUrl, _options)).First();

            }
            else
            {
                teamInfo = await EspnHttpClientService<TeamInfoModel>.GetDataFromEspn(teamInfoUrl, _options);
                rosterInfo = await EspnHttpClientService<RosterInfoModel>.GetDataFromEspn(rosterInfoUrl, _options);
            }
            //var teamInfo = isHistorical ? await EspnHttpClientService<List<TeamInfoModel>>.GetDataFromEspn(teamInfoUrl, _options) : await EspnHttpClientService<TeamInfoModel>.GetDataFromEspn(teamInfoUrl, _options);
            //var rosterInfo = await EspnHttpClientService<RosterInfoModel>.GetDataFromEspn(rosterInfoUrl, _options);

            return TeamStatsViewModelService.CalculateStats(_winningsOptions, teamInfo, rosterInfo);
            
        }
    }
}
