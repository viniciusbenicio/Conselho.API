using Conselho.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conselho.API.Data
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .UseIdentityColumn();

            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasColumnName("Nome")
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(64);
        }
    }
}
