using Conselho.API.Data;
using Conselho.API.Models;
using Conselho.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Conselho.API.Repository
{
    public class UsuarioConselhoRepository : IUsuarioConselhoRepository
    {
        private readonly ConselhoDbContext _context;

        public UsuarioConselhoRepository(ConselhoDbContext context)
        {
            _context = context;
        }

        public Usuario GetByIdUsuarioConselho(int Id)
        {
            return _context.Usuarios.Include(u => u.Slips).Include(e => e.Emails).Where(x => x.Id == Id).FirstOrDefault();

        }

    }
}
