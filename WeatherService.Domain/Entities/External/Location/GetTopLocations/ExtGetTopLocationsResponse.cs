using WeatherService.Domain.Entities.External.Location.Common;

namespace WeatherService.Domain.Entities.External.Location.GetTopLocations
{
    public class ExtGetTopLocationsResponse : ExtBaseResponse
    {
        public List<RootLocation> Locations { get; set; }
    }
}