using Conselho.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Conselho.API.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetUsuarios();
    }
}
