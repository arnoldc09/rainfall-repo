using RainfallApi.Model.Common;
using System.Text.Json.Serialization;

namespace RainfallApi.Model.Contract
{
    public class RainfallContract
    {
        [JsonPropertyName("@context")]
        public string Context { get; set; }

        [JsonPropertyName("meta")]
        public MetaPublisher Meta { get; set; }

        [JsonPropertyName("items")]
        public ItemDetails Items { get; set; }
    }
}
