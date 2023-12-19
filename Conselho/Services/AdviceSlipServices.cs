using Conselho.API.Models;
using Conselho.API.Services.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace Conselho.API.Services
{
    public class AdviceSlipServices : IAdviceSlipServices
    {
        public async Task<AdviceResponse> GetAdviceAsync()
        {
            var client = new RestClient("https://api.adviceslip.com/advice");
            var request = new RestRequest();

            var response = await client.GetAsync(request);

            var slip = JsonConvert.DeserializeObject<AdviceResponse>(response.Content);

            return slip;
        }

    }
}
