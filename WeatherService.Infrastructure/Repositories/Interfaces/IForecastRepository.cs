using WeatherService.Domain.Entities.External.Forecast;
using WeatherService.Domain.Entities.External.Location.GetTopLocations;

namespace WeatherService.Infrastructure.Repositories.Interfaces
{
    public interface IForecastRepository
    {
        Task<ExtGetDayForecastResponse> GetDayForecast(int locationKey, string apiKey);

    }
}
