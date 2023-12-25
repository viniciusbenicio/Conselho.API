using Newtonsoft.Json;

namespace Conselho.API.Models
{
    public class Match
    {
        public string Id { get; set; }
        public string Segment { get; set; }
        public string Translation { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public int Quality { get; set; }
        public object Reference { get; set; }
        [JsonProperty("usage-count")]
        public int UsageCount { get; set; }
        public string Subject { get; set; }
        [JsonProperty("created-by")]
        public string CreatedBy { get; set; }
        [JsonProperty("last-updated-by")]
        public string LastUpdatedBy { get; set; }
        [JsonProperty("create-date")]
        public DateTime CreateDate { get; set; }
        [JsonProperty("last-update-date")]
        public DateTime LastUpdateDate { get; set; }
        public double MatchValue { get; set; }
    }

    public class ResponseData
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
        public double Match { get; set; }
    }

    public class TraducaoResponse
    {
        [JsonProperty("responseData")]
        public ResponseData ResponseData { get; set; }
        [JsonProperty("quotaFinished")]
        public bool QuotaFinished { get; set; }
        [JsonProperty("mtLangSupported")]
        public object MtLangSupported { get; set; }
        [JsonProperty("responseDetails")]
        public string ResponseDetails { get; set; }
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }
        [JsonProperty("responderId")]
        public object ResponderId { get; set; }
        [JsonProperty("exception_code")]
        public object ExceptionCode { get; set; }
        public List<Match> Matches { get; set; }
    }

}
