using FantasyFootballWinningsCalculatorAPI.Enums;
using FantasyFootballWinningsCalculatorAPI.Models.Teams;
using FantasyFootballWinningsCalculatorAPI.Options;
using System.Net;

namespace FantasyFootballWinningsCalculatorAPI.Services
{
    public static class EspnHttpClientService<T> where T : class
    {
        public async static Task<List<T>> GetDataFromEspn(string url, APIOptions options)
        {
            var cookieContainer = new CookieContainer();
           
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })

            using (var client = new HttpClient(handler) { BaseAddress = new Uri(url) })
            {
                
                var content = new FormUrlEncodedContent(new[]
                   {
                    new KeyValuePair<string, string>(Enum.GetName(typeof(CookieKeys), 0), options.SWIDCookie),
                    new KeyValuePair<string, string>(Enum.GetName(typeof(CookieKeys), 1), options.Espn_S2Cookie)
                });

                cookieContainer.Add(new Uri(url), new Cookie(Enum.GetName(typeof(CookieKeys), 0), options.SWIDCookie));
                cookieContainer.Add(new Uri(url), new Cookie(Enum.GetName(typeof(CookieKeys), 1), options.Espn_S2Cookie));

                var output = await client.GetFromJsonAsync<List<T>>(url);

                return output;
            }
        }
    }
}
