using Fiap.BRQ.Api.Actions;
using Fiap.BRQ.Infrastructure.ApplicationConfiguration;
using Fiap.BRQ.Infrastructure.ApplicationServices;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.OpenApi.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

var builderInDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "BRQ Candidatos API",
        Description = "Api para cadastro e consulta de candidatos para a BRQ",        
        Contact = new OpenApiContact
        {
            Name = "brq.com",
            Url = new Uri("https://www.brq.com/")
        },
    });
});

builder.Services.AddAutoMapperApplication(typeof(Program).Assembly);
builder.Services.AddDBContextApplication(IsDevelopment: builderInDevelopment);
builder.Services.AddServiceApplication();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

// Endpoints
app.MapCandidatoEndpoint();
app.MapEspecialidadeEndpoint();
app.MapCertificadoEndpoint();

app.Run();