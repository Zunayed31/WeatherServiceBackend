using WeatherService.Api.DTOs;

namespace WeatherService.Api.Services.Interfaces
{
    public interface IForecastService
    {
        Task<GetDayForecastResponse> GetDayForecast(int locationKey);
    }
}
