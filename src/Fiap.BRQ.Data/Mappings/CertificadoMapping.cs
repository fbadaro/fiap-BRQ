using Fiap.BRQ.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.BRQ.Data.Mappings;

internal class CertificadoMapping : IEntityTypeConfiguration<Certificado>
{
    public void Configure(EntityTypeBuilder<Certificado> builder)
    {
        builder.ToTable("BRQ03_CERTIFICADO");

        builder.HasKey(x => x.Id);

        builder.Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(c => c.OrganizacaoEmissora)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(c => c.CodigoCredencial)            
            .HasMaxLength(50);

        builder.Property(c => c.UrlCredencial)            
            .HasMaxLength(500);
    }
}
