using Newtonsoft.Json;

namespace PokeDexApp.Models
{
    public partial class Doctor
    {
        public partial class FaceBookProfile
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("birthday")]
            public string Birthday { get; set; }

            [JsonProperty("picture")]
            public Picture Picture { get; set; }
        }
    }
}
