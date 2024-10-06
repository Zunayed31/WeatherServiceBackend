using WeatherService.Api.Services.Interfaces;
using WeatherService.Domain.Entities.External;
using WeatherService.Infrastructure.Repositories.Interfaces;

namespace WeatherService.Api.Services
{
    public class ForecastService : IForecastService
    {
        private IForecastRepository _forecastRepository;

        public ForecastService(IForecastRepository forecastRepository) 
        {
            _forecastRepository = forecastRepository;
        }

        #region GetWeather

        public async Task<List<int>> GetWeather()
        {
            return null;
        }

        #endregion GetWeather        
    }
}
