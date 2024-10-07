using WeatherService.Domain.Entities.External.Forecast;
namespace WeatherService.Api.DTOs
{
    public class GetDayForecastResponse : BaseResponse
    {
        public RootForecast Forecast { get; set; }
    }
}
