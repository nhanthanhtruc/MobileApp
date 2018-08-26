using Newtonsoft.Json;

namespace PokeDexApp.Models
{
    public partial class Doctor
    {
        public partial class Picture
        {
            [JsonProperty("data")]
            public DataPicture Data { get; set; }
        }
    }
}
