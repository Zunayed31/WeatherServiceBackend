using WeatherService.Api.DTOs;
using WeatherService.Api.Services.Interfaces;
using WeatherService.Domain.Entities.External.Forecast;
using WeatherService.Infrastructure.Repositories.Interfaces;

namespace WeatherService.Api.Services
{
    public class ForecastService : IForecastService
    {
        private IForecastRepository _forecastRepository;
        private readonly IConfiguration _configuration;

        public ForecastService(IForecastRepository forecastRepository, IConfiguration configuration)
        {
            _forecastRepository = forecastRepository;
            _configuration = configuration;
        }

        #region GetDayForecast

        public async Task<GetDayForecastResponse> GetDayForecast(int locationKey)
        {
            string apiKey = _configuration[Domain.Constants.Constants.ACCU_WEATHER_API_KEY];
            var repoResponse = await _forecastRepository.GetDayForecast(locationKey, apiKey);

            foreach (var temp in repoResponse.Forecast.DailyForecasts) 
            {
                temp.Temperature.Maximum.Value = (float) Math.Ceiling(5.0 / 9.0 * (temp.Temperature.Maximum.Value - 32));
                temp.Temperature.Maximum.Unit = "C";
                temp.Temperature.Minimum.Value = (float) Math.Floor(5.0 / 9.0 * (temp.Temperature.Minimum.Value - 32));
                temp.Temperature.Minimum.Unit = "C";
            }

            return new GetDayForecastResponse
            {
                Forecast = repoResponse.Forecast,
                StatusCode = repoResponse.StatusCode
            };
        }

        #endregion GetDayForecast        
    }
}
