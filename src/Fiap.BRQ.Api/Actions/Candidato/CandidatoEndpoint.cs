using Fiap.BRQ.Application.Candidato;

namespace Fiap.BRQ.Api.Actions;

public static class CandidatoEndpoint
{
    public static void MapCandidatoEndpoint(this WebApplication? app)
    {
        // LIST
        app!.MapGet("/candidato", async (ICandidatoService _candidatoAppService) =>
            await _candidatoAppService.GetAllAsync())
        .Produces<List<CandidatoDTO>>(StatusCodes.Status200OK)
        .WithName("GetCandidato")
        .WithTags("Candidato");

        // FIND
        app!.MapGet("/candidato/find", async (int page, string especialidade, string? candidato, ICandidatoService _especialidadeAppService) =>
        {            
            var result = await _especialidadeAppService.FindAllByEspecialidadeAsync(page, especialidade, candidato!);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<List<CandidatoDTO>>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("FindCandidato")
        .WithTags("Candidato");

        // GET
        app!.MapGet("/candidato/{id}", async (ICandidatoService _candidatoAppService, Guid id) =>
        {
            var result = await _candidatoAppService.GetById(id);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<CandidatoDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("GetCandidatoById")
        .WithTags("Candidato");

        // POST
        app!.MapPost("/candidato", async (ICandidatoService _candidatoAppService, CandidatoDTO Candidato) =>
        {
            var result = await _candidatoAppService.CreateAsync(Candidato);

            return result != null
            ? Results.CreatedAtRoute("GetCandidatoById", new { id = result.Id }, Candidato)
            : Results.BadRequest("Houve um problema ao salvar o registro");
        })
        .Produces<CandidatoDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostCandidato")
        .WithTags("Candidato");

        // UPDATE
        app!.MapPut("/candidato/{id}", async (ICandidatoService _candidatoAppService, Guid id, CandidatoDTO Candidato) =>
        {
            var result = await _candidatoAppService.UpdateAsync(Candidato);

            return result != null
                ? Results.NoContent()
                : Results.BadRequest("Houve um problema ao salvar o registro");

        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PutCandidato")
        .WithTags("Candidato");

        // DELETE
        app!.MapDelete("/candidato/{id}", async (ICandidatoService _candidatoAppService, Guid id) =>
            await _candidatoAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("DeleteCandidato")
        .WithTags("Candidato");
    }
}
