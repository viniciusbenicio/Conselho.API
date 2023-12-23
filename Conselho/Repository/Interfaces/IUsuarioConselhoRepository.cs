using Conselho.API.Models;

namespace Conselho.API.Repository.Interfaces
{
    public interface IUsuarioConselhoRepository
    {
        Usuario GetByIdUsuarioConselho(int Id);
    }
}
