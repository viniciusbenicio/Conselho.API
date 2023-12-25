using Conselho.API.Models;
using Conselho.API.Services.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System.Text.RegularExpressions;

namespace Conselho.API.Services
{
    public class TraducaoServices : ITraducaoServices
    {
        public async Task<string> RealizarTraducao(string text = "", string translateFrom = "en", string translateTo = "pt")
        {
            var client = new RestClient($"https://api.mymemory.translated.net/get?q=${text}&langpair={translateFrom}|{translateTo}");
            var request = new RestRequest();
            var response = await client.GetAsync(request);
            var traducao = JsonConvert.DeserializeObject<TraducaoResponse>(response.Content);

            var textoFormatado  = RemoverCaracterEspecial(traducao.ResponseData.TranslatedText);

            return textoFormatado;
           
        }

        static string RemoverCaracterEspecial(string input)
        {
            string pattern = "\\$";
            string replacement = "";
            Regex regex = new Regex(pattern);
            string output = regex.Replace(input, replacement);

            return output;
        }
    }
}
