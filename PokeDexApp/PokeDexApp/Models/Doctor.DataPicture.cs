using Newtonsoft.Json;

namespace PokeDexApp.Models
{
    public partial class Doctor
    {
        public partial class DataPicture
        {
            [JsonProperty("height")]
            public long Height { get; set; }

            [JsonProperty("is_silhouette")]
            public bool IsSilhouette { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("width")]
            public long Width { get; set; }
        }
    }
}
