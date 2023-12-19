using Newtonsoft.Json;

namespace Conselho.API.Models
{
    public class Slip
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("advice")]
        public string Advice { get; set; }
    }

    public class AdviceResponse
    {
        [JsonProperty("slip")]
        public Slip Slip { get; set; }
    }

}
