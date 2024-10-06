using WeatherService.Domain.Entities.External.Location.GetTopLocations;

namespace WeatherService.Infrastructure.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        Task<ExtGetTopLocationsResponse> GetTopLocations(int group, string apiKey);
    }
}
