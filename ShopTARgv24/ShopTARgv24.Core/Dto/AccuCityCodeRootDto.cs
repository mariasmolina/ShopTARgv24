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
        public RegionCountry? Region { get; set; }
        public RegionCountry? Country { get; set; }
        public AdministrativeArea? AdministrativeArea { get; set; }
        public TimeZone? TimeZone { get; set; }
        public GeoPosition? GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public SupplementalAdminAreas[]? SupplementalAdminAreas { get; set; }
        public string[]? DataSets { get; set; }

    }

    public class RegionCountry
    {
        public string? ID { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
    }

    public class AdministrativeArea
    {
        public string? ID { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
        public int Level { get; set; }
        public string? LocalizedType { get; set; }
        public string? EnglishType { get; set; }
        public string? CountryID { get; set; }
    }

    public class TimeZone
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public DateTime? NextOffsetChange { get; set; }
    }

    public class GeoPosition
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Elevation? Elevation { get; set; }
    }

    public class Elevation
    {
        public ElevationWeatherValue? Metric { get; set; }
        public ElevationWeatherValue? Imperial { get; set; }
    }

    public class ElevationWeatherValue
    {
       public int Value { get; set; } 
         public string? Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class SupplementalAdminAreas
    {
        public int Level { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
    }
}
