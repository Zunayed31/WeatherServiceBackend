using WeatherService.Domain.Entities.External.Location.Common;
namespace WeatherService.Api.DTOs
{
    public class GetTopLocationsResponse : BaseResponse
    {
        public List<RootLocation> Locations { get; set; }
    }
}
