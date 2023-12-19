using Conselho.API.Models;

namespace Conselho.API.Services.Interfaces
{
    public interface IAdviceSlipServices
    {
        Task<AdviceResponse> GetAdviceAsync();

    }
}
