using Conselho.API.Models;

namespace Conselho.API.Services.Interfaces
{
    public interface ITraducaoServices
    {
        Task<string> RealizarTraducao(string text = "", string translateFrom = "en", string translateTo = "pt");
    }
}
