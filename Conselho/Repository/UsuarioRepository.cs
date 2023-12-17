using Conselho.API.Data;
using Conselho.API.Models;
using Conselho.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Conselho.API.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ConselhoDbContext _context;

        public UsuarioRepository(ConselhoDbContext context)
        {
            _context = context;
        }
        public Task<Usuario> GetUsuarioAsync(int id)
        {
            return _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
