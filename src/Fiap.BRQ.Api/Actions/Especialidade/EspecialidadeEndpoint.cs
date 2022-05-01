using Fiap.BRQ.Application.Especialidade;

namespace Fiap.BRQ.Api.Actions;

public static class EspecialidadeEndpoint
{
    public static void MapEspecialidadeEndpoint(this WebApplication? app)
    {
        // LIST
        app!.MapGet("/especialidade", async (IEspecialidadeService _especialidadeAppService) =>
            await _especialidadeAppService.GetAllAsync())
        .Produces<List<EspecialidadeDTO>>(StatusCodes.Status200OK)
        .WithName("GetEspecialidade")
        .WithTags("Especialidade");        

        // GET
        app!.MapGet("/especialidade/{id}", async (IEspecialidadeService _especialidadeAppService, Guid id) =>
        {
            var result = await _especialidadeAppService.GetById(id);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<EspecialidadeDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("GetEspecialidadeById")
        .WithTags("Especialidade");

        // POST
        app!.MapPost("/especialidade", async (IEspecialidadeService _especialidadeAppService, EspecialidadeDTO Especialidade) =>
        {
            var result = await _especialidadeAppService.CreateAsync(Especialidade);

            return result != null
            ? Results.CreatedAtRoute("GetEspecialidadeById", new { id = result.Id }, Especialidade)
            : Results.BadRequest("Houve um problema ao salvar o registro");
        })
        .Produces<EspecialidadeDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostEspecialidade")
        .WithTags("Especialidade");

        // UPDATE
        app!.MapPut("/especialidade/{id}", async (IEspecialidadeService _especialidadeAppService, Guid id, EspecialidadeDTO Especialidade) =>
        {
            var result = await _especialidadeAppService.UpdateAsync(Especialidade);

            return result != null
                ? Results.NoContent()
                : Results.BadRequest("Houve um problema ao salvar o registro");

        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PutEspecialidade")
        .WithTags("Especialidade");

        // DELETE
        app!.MapDelete("/especialidade/{id}", async (IEspecialidadeService _especialidadeAppService, Guid id) =>
            await _especialidadeAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("DeleteEspecialidade")
        .WithTags("Especialidade");
    }
}
