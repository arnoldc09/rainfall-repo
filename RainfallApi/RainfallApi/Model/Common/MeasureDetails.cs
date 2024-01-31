using System.Text.Json.Serialization;

namespace RainfallApi.Model.Common
{
    public class MeasureDetails
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("latestReading")]
        public LatestReadingDetail LatestReading { get; set; }

        [JsonPropertyName("notation")]
        public string Notation { get; set; }

        [JsonPropertyName("parameter")]
        public string Parameter { get; set; }

        [JsonPropertyName("parameterName")]
        public string ParameterName { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("qualifier")]
        public string Qualifier { get; set; }

        [JsonPropertyName("station")]
        public string Station { get; set; }

        [JsonPropertyName("stationReference")]
        public string StationReference { get; set; }

        [JsonPropertyName("type")]
        public string[] Type { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("unitName")]
        public string UnitName { get; set; }

        [JsonPropertyName("valueType")]
        public string ValueType { get; set; }
    }
}
