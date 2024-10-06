using System.Net;

namespace WeatherService.Domain.Entities.External
{
    public class ExtBaseResponse
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
