using Conselho.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conselho.API.Data
{
    public class SlipMap : IEntityTypeConfiguration<Slip>
    {
        public void Configure(EntityTypeBuilder<Slip> builder)
        {
            builder.ToTable("Slip");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .UseIdentityColumn();

            builder.Property(x => x.IdSlip);

            builder.Property(x => x.Conselho)
                   .IsRequired()
                   .HasColumnName("Descricao")
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(255);
        }
    }
}
