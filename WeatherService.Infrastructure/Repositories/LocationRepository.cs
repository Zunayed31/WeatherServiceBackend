using RestWrapper;
using System.Net;
using System.Text.Json;
using WeatherService.Domain.Entities.External.Location.Common;
using WeatherService.Domain.Entities.External.Location.GetTopLocations;
using WeatherService.Infrastructure.Repositories.Interfaces;

namespace WeatherService.Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        #region GetTopLocations

        public async Task<ExtGetTopLocationsResponse> GetTopLocations(int group, string apiKey)
        {
            // simple GET example
            var req = new RestRequest($"http://dataservice.accuweather.com/locations/v1/topcities/{group}?apikey={apiKey}");
            var resp = await req.SendAsync();            

            var locations = JsonSerializer.Deserialize<List<RootLocation>>(resp.DataAsString);

            return new ExtGetTopLocationsResponse() 
            {
                Locations = locations,
                StatusCode = (HttpStatusCode) resp.StatusCode
            };
        }

        #endregion GetTopLocations
    }
}
