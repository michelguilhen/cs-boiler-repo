using BoilerPlateWithRepos.Api.Data.Repositories.Interfaces;
using BoilerPlateWithRepos.Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;

namespace BoilerPlateWithRepos.Api.Endpoints;
public static class GamesEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("api/games", async (IGamesRepository repository) =>
        {
            var games = await repository.FindAsync();
            return Results.Ok(games);
        })
        .WithName("Get Games")
        .WithOpenApi();

        app.MapGet("api/games/{id}", async (IGamesRepository repository, Guid id) =>
        {
            var game = await repository.FindByIdAsync(id);
            return Results.Ok(game);
        })
        .WithName("Get Game By Id")
        .WithOpenApi();

        app.MapPost("api/games", async (IGamesRepository repository, Game game) =>
        {
            return Results.Ok(await repository.CreateAsync(game));
        })
        .WithName("Create Game")
        .WithOpenApi();

        app.MapPut("api/games/{id}", async (IGamesRepository repository, Game game, Guid id) =>
        {
            if (game.Id != id)
            {
                return Results.BadRequest();
            }
            return Results.Ok(await repository.UpdateAsync(game));
        })
        .WithName("Update Game")
        .WithOpenApi();

        app.MapDelete("api/games/{id}", async (IGamesRepository repository, Guid id) =>
        {
            await repository.DeleteAsync(id);
            return Results.NoContent();
        })
        .WithName("Delete Game")
        .WithOpenApi();
    }
}
