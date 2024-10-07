using Microsoft.AspNetCore.Mvc;
using WeatherService.Api.Services.Interfaces;

namespace WeatherService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IForecastService _forecastService;
        private readonly ILocationService _locationService;

        public WeatherForecastController(IForecastService forecastService, ILocationService locationService)
        {
            _forecastService = forecastService;
            _locationService = locationService;
        }

        [HttpGet("/[controller]/Forecast/{locationKey}")]
        public async Task<ActionResult> GetDayForecast(int locationKey)
        {
            var response = _forecastService.GetDayForecast(locationKey);

            return StatusCode(200, response.Result);
        }

        [HttpGet("/[controller]/Location/{group}")]
        public async Task<ActionResult> GetTopLocations(int group)
        {
            var response = await _locationService.GetTopLocations(group);

            return StatusCode((int) response.StatusCode, response);
        }
    }
}
