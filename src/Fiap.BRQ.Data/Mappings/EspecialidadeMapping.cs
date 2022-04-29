using Fiap.BRQ.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.BRQ.Data.Mappings;

internal class EspecialidadeMapping : IEntityTypeConfiguration<Especialidade>
{
    public void Configure(EntityTypeBuilder<Especialidade> builder)
    {
        builder.ToTable("BRQ02_ESPECIALIDADE");

        builder.HasKey(x => x.Id);

        builder.Property(e => e.Nome)
            .IsRequired()
            .HasMaxLength(150);
    }
}
