using System.Text.Json.Serialization;

namespace RainfallApi.Model.Common
{
    public class MetaPublisher
    {
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        [JsonPropertyName("licence")]
        public string Licence { get; set; }

        [JsonPropertyName("documentation")]
        public string Documentation { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("hasFormat")]
        public string[] HasFormat { get; set; }
    }
}
