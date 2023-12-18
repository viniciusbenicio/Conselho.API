using Conselho.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Conselho.API.Data
{
    public class ConselhoDbContext : DbContext
    {
        public ConselhoDbContext(DbContextOptions<ConselhoDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Email> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new EmailMap());
        }
    }
}
