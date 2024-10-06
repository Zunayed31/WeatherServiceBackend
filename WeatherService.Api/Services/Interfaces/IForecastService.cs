namespace WeatherService.Api.Services.Interfaces
{
    public interface IForecastService
    {
        Task<List<int>> GetWeather();
    }
}
