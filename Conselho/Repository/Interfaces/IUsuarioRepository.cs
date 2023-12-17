using Conselho.API.Models;

namespace Conselho.API.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUsuarioAsync(int id);
    }
}
