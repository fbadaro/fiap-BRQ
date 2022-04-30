using Fiap.BRQ.Application.Candidato;

namespace Fiap.BRQ.Api.Actions;

public static class CandidatoEndpoint
{
    public static void MapCandidatoEndpoint(this WebApplication? app)
    {
        // LIST
        app!.MapGet("/candidato", async (ICandidatoService _CandidatoAppService) =>
            await _CandidatoAppService.GetAllAsync())
        .Produces<List<CandidatoDTO>>(StatusCodes.Status200OK)
        .WithName("GetCandidato")
        .WithTags("Candidato");

        // GET
        app!.MapGet("/candidato/{id}", async (ICandidatoService _CandidatoAppService, Guid id) =>
        {
            var result = await _CandidatoAppService.GetById(id);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<CandidatoDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("GetCandidatoById")
        .WithTags("Candidato");

        // POST
        app!.MapPost("/candidato", async (ICandidatoService _CandidatoAppService, CandidatoDTO Candidato) =>
        {
            var result = await _CandidatoAppService.CreateAsync(Candidato);

            return result != null
            ? Results.CreatedAtRoute("GetCandidatoById", new { id = result.Id }, Candidato)
            : Results.BadRequest("Houve um problema ao salvar o registro");
        })
        .Produces<CandidatoDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostCandidato")
        .WithTags("Candidato");

        // UPDATE
        app!.MapPut("/candidato/{id}", async (ICandidatoService _CandidatoAppService, Guid id, CandidatoDTO Candidato) =>
        {
            var result = await _CandidatoAppService.UpdateAsync(Candidato);

            return result != null
                ? Results.NoContent()
                : Results.BadRequest("Houve um problema ao salvar o registro");

        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PutCandidato")
        .WithTags("Candidato");

        // DELETE
        app!.MapDelete("/candidato/{id}", async (ICandidatoService _CandidatoAppService, Guid id) =>
            await _CandidatoAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("DeleteCandidato")
        .WithTags("Candidato");
    }
}
