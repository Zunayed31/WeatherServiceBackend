using WeatherService.Domain.Entities.External.Location.GetTopLocations;

namespace WeatherService.Domain.Entities.External.Location.Common
{
    public class RootLocation
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public Region Region { get; set; }
        public Country Country { get; set; }
        public Administrativearea AdministrativeArea { get; set; }
        public Timezone TimeZone { get; set; }
        public Geoposition GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public Supplementaladminarea[] SupplementalAdminAreas { get; set; }
        public string[] DataSets { get; set; }
    }
}