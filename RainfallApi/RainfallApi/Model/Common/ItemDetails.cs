using System.Text.Json.Serialization;

namespace RainfallApi.Model.Common
{
    public class ItemDetails
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("eaRegionName")]
        public string EaRegionName { get; set; }

        [JsonPropertyName("easting")]
        public string Easting { get; set; }

        [JsonPropertyName("gridReference")]
        public string GridReference { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("measures")]
        public MeasureDetails[] Measures { get; set; }

        [JsonPropertyName("northing")]
        public string Northing { get; set; }

        [JsonPropertyName("notation")]
        public string Notation { get; set; }

        [JsonPropertyName("stationReference")]
        public string StationReference { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
