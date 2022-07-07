using FantasyFootballWinningsCalculatorAPI.Models.League;
using FantasyFootballWinningsCalculatorAPI.Models.Teams;
using FantasyFootballWinningsCalculatorAPI.Options;
using FantasyFootballWinningsCalculatorAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FantasyFootballWinningsCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly APIOptions _options;

        public TeamsController(IOptions<APIOptions> options) => _options = options.Value;

        [HttpGet]
        [Route("{year}/{isHistorical}")]
        public async Task<List<Team>> GetTeams(int year, bool isHistorical)
        {
            var path = isHistorical ? _options.HistoricalPath : $"{ _options.CurrentPath}/{year}/segments/0/leagues";

            var url = $"{path}/{_options.LeagueId}?seasonId={year}";

            var leagueInfo = isHistorical ? 
                (await EspnHttpClientService<List<LeagueInfoModel>>.GetDataFromEspn(url, _options)).First() :
                await EspnHttpClientService<LeagueInfoModel>.GetDataFromEspn(url, _options);

            return leagueInfo.teams;
        }
    }
}
