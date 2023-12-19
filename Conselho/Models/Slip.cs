using Newtonsoft.Json;

namespace Conselho.API.Models
{
    public class Slip
    {
        public int Id { get; set; }
        [JsonProperty("id")]
        public int? IdSlip { get; set; }

        [JsonProperty("advice")]
        public string Conselho { get; set; }

        public Usuario Usuario { get; set; }
    }

    public class AdviceResponse
    {
        [JsonProperty("slip")]
        public Slip Conselho { get; set; }
    }

}
