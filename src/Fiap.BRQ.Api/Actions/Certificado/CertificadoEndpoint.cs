using Fiap.BRQ.Application.Certificado;

namespace Fiap.BRQ.Api.Actions;

public static class CertificadoEndpoint
{
    public static void MapCertificadoEndpoint(this WebApplication? app)
    {
        // LIST
        app!.MapGet("/certificado", async (ICertificadoService _certificadoAppService) =>
            await _certificadoAppService.GetAllAsync())
        .Produces<List<CertificadoDTO>>(StatusCodes.Status200OK)
        .WithName("GetCertificado")
        .WithTags("Certificado");

        // GET
        app!.MapGet("/certificado/{id}", async (ICertificadoService _certificadoAppService, Guid id) =>
        {
            var result = await _certificadoAppService.GetById(id);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<CertificadoDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("GetCertificadoById")
        .WithTags("Certificado");

        // POST
        app!.MapPost("/certificado", async (ICertificadoService _certificadoAppService, CertificadoDTO Certificado) =>
        {
            var result = await _certificadoAppService.CreateAsync(Certificado);

            return result != null
            ? Results.CreatedAtRoute("GetCertificadoById", new { id = result.Id }, Certificado)
            : Results.BadRequest("Houve um problema ao salvar o registro");
        })
        .Produces<CertificadoDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostCertificado")
        .WithTags("Certificado");

        // UPDATE
        app!.MapPut("/certificado/{id}", async (ICertificadoService _certificadoAppService, Guid id, CertificadoDTO Certificado) =>
        {
            var result = await _certificadoAppService.UpdateAsync(Certificado);

            return result != null
                ? Results.NoContent()
                : Results.BadRequest("Houve um problema ao salvar o registro");

        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PutCertificado")
        .WithTags("Certificado");

        // DELETE
        app!.MapDelete("/certificado/{id}", async (ICertificadoService _certificadoAppService, Guid id) =>
            await _certificadoAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("DeleteCertificado")
        .WithTags("Certificado");
    }
}
