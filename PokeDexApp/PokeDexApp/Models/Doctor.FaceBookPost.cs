using Newtonsoft.Json;

namespace PokeDexApp.Models
{
    public partial class Doctor
    {
        public partial class FaceBookPost
        {
            [JsonProperty("posts")]
            public Posts Posts { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }
        }
    }
}
