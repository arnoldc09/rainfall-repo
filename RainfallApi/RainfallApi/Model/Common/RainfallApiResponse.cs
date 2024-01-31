using System.Text.Json.Serialization;

namespace RainfallApi.Model.Common
{
    public class RainfallApiResponse
    {
        [JsonPropertyName("@context")]
        public string @Context { get; set; }

        [JsonPropertyName("meta")]
        public MetaPublisher Meta { get; set; }

        [JsonPropertyName("items")]
        public ItemDetails Items { get; set; }
    }
}
