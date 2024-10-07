using RestWrapper;
using System.Net;
using System.Text.Json;
using WeatherService.Domain.Entities.External.Forecast;
using WeatherService.Infrastructure.Repositories.Interfaces;

namespace WeatherService.Infrastructure.Repositories
{
    public class ForecastRepository : IForecastRepository
    {
        #region GetDayForecast

        public async Task<ExtGetDayForecastResponse> GetDayForecast(int locationKey, string apiKey)
        {
            // simple GET example
            var req = new RestRequest($"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{locationKey}?apikey={apiKey}");
            var resp = await req.SendAsync();

            var forecast = JsonSerializer.Deserialize<RootForecast>(resp.DataAsString);

            return new ExtGetDayForecastResponse()
            {
                Forecast = forecast,
                StatusCode = (HttpStatusCode)resp.StatusCode
            };
        }
        #endregion GetDayForecast
    }
}
