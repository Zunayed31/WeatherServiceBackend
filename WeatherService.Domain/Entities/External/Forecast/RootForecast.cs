namespace WeatherService.Domain.Entities.External.Forecast
{
    public class RootForecast
    {
        public Headline Headline { get; set; }
        public Dailyforecast[] DailyForecasts { get; set; }
    }
}
