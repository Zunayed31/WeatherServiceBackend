using WeatherService.Api.DTOs;

namespace WeatherService.Api.Services.Interfaces
{
    public interface ILocationService
    {
        Task<GetTopLocationsResponse> GetTopLocations(int group);
    }
}
