using WeatherService.Api.DTOs;
using WeatherService.Api.Services.Interfaces;
using WeatherService.Infrastructure.Repositories.Interfaces;

namespace WeatherService.Api.Services
{
    public class LocationService : ILocationService
    {
        private ILocationRepository _locationRepository;
        private readonly IConfiguration _configuration;

        public LocationService(ILocationRepository locationRepository, IConfiguration configuration)
        {
            _locationRepository = locationRepository;
            _configuration = configuration;
        }

        #region GetTopLocations

        public async Task<GetTopLocationsResponse> GetTopLocations(int group)
        {
            string apiKey = _configuration[Domain.Constants.Constants.ACCU_WEATHER_API_KEY];
            var repoResponse = await _locationRepository.GetTopLocations(group, apiKey);

            return new GetTopLocationsResponse() 
            {
                Locations = repoResponse.Locations,
                StatusCode = repoResponse.StatusCode
            };
        }

        #endregion GetTopLocations
    }
}
