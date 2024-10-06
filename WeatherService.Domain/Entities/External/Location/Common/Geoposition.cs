using WeatherService.Domain.Entities.External.Location.Common;

namespace WeatherService.Domain.Entities.External.Location.GetTopLocations
{
    public class Geoposition
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public Elevation Elevation { get; set; }
    }
}