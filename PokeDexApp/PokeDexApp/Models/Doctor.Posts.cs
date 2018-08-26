using Newtonsoft.Json;

namespace PokeDexApp.Models
{
    public partial class Doctor
    {
        public partial class Posts
        {
            [JsonProperty("data")]
            public PostData[] Data { get; set; }            
        }
    }
}
