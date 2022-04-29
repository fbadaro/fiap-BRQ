using Fiap.BRQ.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Fiap.BRQ.Data;

public class BRQDBContext : DbContext
{
    public BRQDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Candidato> Candidatos { get; set; } = null!;

    public DbSet<Especialidade> Especialidades { get; set; } = null!;

    public DbSet<Certificado> Certificados { get; set; } = null!;    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BRQDBContext).Assembly);
    }
}
