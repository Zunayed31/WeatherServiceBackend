namespace WeatherService.Domain.Entities.External.Forecast
{
    public class ExtGetDayForecastResponse : ExtBaseResponse
    {
        public RootForecast Forecast { get; set; }
    }
}
