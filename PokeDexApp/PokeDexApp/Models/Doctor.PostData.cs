using Newtonsoft.Json;

namespace PokeDexApp.Models
{
    public partial class Doctor
    {
        public partial class PostData
        {
            [JsonProperty("full_picture", NullValueHandling = NullValueHandling.Ignore)]
            public string FullPicture { get; set; }

            [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
            public string Message { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }
            public bool HasMessage => !string.IsNullOrEmpty(Message);
            public bool HasFullPicture => !string.IsNullOrEmpty(FullPicture);
        }
    }
}
