using Fiap.BRQ.Application.Candidato;
using Fiap.BRQ.Application.Certificado;
using Fiap.BRQ.Application.Especialidade;
using Fiap.BRQ.Core.Domain;
using Fiap.BRQ.Data;
using Fiap.BRQ.Data.Repository.Candidato;
using Fiap.BRQ.Data.Repository.Certificado;
using Fiap.BRQ.Data.Repository.Especialidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.BRQ.Infrastructure.ApplicationServices;

public static class ApplicationBootstraper
{
    public static void AddDBContextApplication(this IServiceCollection services, bool IsDevelopment)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + "/../Fiap.BRQ.Api/appsettings.json")
                .Build();

        //if (IsDevelopment)
        //    services.AddDbContext<BRQDBContext>(options =>
        //        options.UseInMemoryDatabase("UseInMemoryDatabase"));

        services.AddDbContext<BRQDBContext>(options =>
                options.UseSqlServer(configuration["SqlServer:ConnectionString"]));
    }

    public static void AddServiceApplication(this IServiceCollection services)
    {
        // Candidato Service/Repository
        services.AddScoped<ICandidatoService, CandidatoService>();
        services.AddScoped<ICandidatoRepository, CandidatoRepository>();
        services.AddScoped<IRepositoryBase<Candidato, Guid>, RepositorySQLBase<Candidato, Guid>>();
        services.AddSingleton<CandidatoValidator>();

        // Especilidade Service/Repository
        services.AddScoped<IEspecialidadeService, EspecialidadeService>();
        services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
        services.AddScoped<IRepositoryBase<Especialidade, Guid>, RepositorySQLBase<Especialidade, Guid>>();

        // Certificado Service/Repository
        services.AddScoped<ICertificadoService, CertificadoService>();
        services.AddScoped<ICertificadoRepository, CertificadoRepository>();
        services.AddScoped<IRepositoryBase<Certificado, Guid>, RepositorySQLBase<Certificado, Guid>>();

        // DBContext
        services.AddScoped<DbContext>();
    }
}
