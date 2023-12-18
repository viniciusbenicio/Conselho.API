using Conselho.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conselho.API.Data
{
    public class EmailMap : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("Emails");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .UseIdentityColumn();

            builder.Property(x => x.Endereco)
                   .IsRequired()
                   .HasColumnName("Endereco")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(120);

            builder.HasOne(x => x.Usuario)
                 .WithMany(x => x.Emails)
                 .HasConstraintName("FK_Emails_Usuarios")
                 .OnDelete(DeleteBehavior.NoAction);
     
        }
    }
}
