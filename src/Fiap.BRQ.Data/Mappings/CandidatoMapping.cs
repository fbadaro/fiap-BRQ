using Fiap.BRQ.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.BRQ.Data.Mappings;

internal class CandidatoMapping : IEntityTypeConfiguration<Candidato>
{
    public void Configure(EntityTypeBuilder<Candidato> builder)
    {
        builder.ToTable("BRQ01_CANDIDATO");

        builder.HasKey(c => c.Id);

        builder.OwnsOne(c => c.CPF, cpf =>
        {
            cpf.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(11);

            cpf.Property(c => c.Emissor)
                .IsRequired()
                .HasMaxLength(5);

            cpf.Property(c => c.UF)
                .IsRequired()
                .HasMaxLength(2);
        });

        builder.OwnsOne(c => c.Email, email =>
        {
            email.Property(e => e.Endereco)
                .IsRequired()
                .HasMaxLength(150);
        });

        builder.Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.OwnsOne(c => c.Endereco, endereco =>
        {
            endereco.Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            endereco.Property(e => e.Complemento)
                .IsRequired()
                .HasMaxLength(30);

            endereco.Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(150);

            endereco.Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(9);
        });

        builder.OwnsOne(c => c.RG, rg =>
        {
            rg.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(15);
        });
    }
}
