using System.Net;

namespace WeatherService.Api.DTOs
{
    public class BaseResponse
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
