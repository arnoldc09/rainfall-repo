using System.Text.Json.Serialization;

namespace RainfallApi.Model.Common
{
    public class LatestReadingDetail
    {

        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("dateTime")]
        public string DateTime { get; set; }

        [JsonPropertyName("measure")]
        public string Measure { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
