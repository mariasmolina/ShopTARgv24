namespace ShopTARgv24.Core.Dto
{
    public class AccuCityCodeRootDto
    {
        public string? Version { get; set; }
        public int Key { get; set; }
        public string? Type { get; set; }
        public int Rank { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
        public int PrimaryPostalCode { get; set; }
        public RegionCountryDto? Region { get; set; }
        public RegionCountryDto? Country { get; set; }
        public AdministrativeAreaDto? AdministrativeArea { get; set; }
        public TimeZoneDto? TimeZone { get; set; }
        public GeoPositionDto? GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public SupplementalAdminAreasDto[]? SupplementalAdminAreas { get; set; }
        public string[]? DataSets { get; set; }

    }

    public class RegionCountryDto
    {
        public string? ID { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
    }

    public class AdministrativeAreaDto
    {
        public string? ID { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
        public int Level { get; set; }
        public string? LocalizedType { get; set; }
        public string? EnglishType { get; set; }
        public string? CountryID { get; set; }
    }

    public class TimeZoneDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public DateTime? NextOffsetChange { get; set; }
    }

    public class GeoPositionDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ElevationDto? Elevation { get; set; }
    }

    public class ElevationDto
    {
        public ElevationWeatherValueDto? Metric { get; set; }
        public ElevationWeatherValueDto? Imperial { get; set; }
    }

    public class ElevationWeatherValueDto
    {
       public int Value { get; set; } 
         public string? Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class SupplementalAdminAreasDto
    {
        public int Level { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
    }
}
