using AutoMapper;
using Fiap.BRQ.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.BRQ.Infrastructure.ApplicationConfiguration;

public static class AutoMapperConfiguration
{
    public static void AddAutoMapperApplication(this IServiceCollection services, params System.Reflection.Assembly[] assemblies)
    {
        services.AddAutoMapper(assemblies);
        services.AddSingleton<IConfigurationProvider>(AutoMapperConfig.RegisterMappings());
    }
}
