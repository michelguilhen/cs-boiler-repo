using BoilerPlateWithRepos.Api.Data.Repositories.Interfaces;
using BoilerPlateWithRepos.Api.Entities;

namespace BoilerPlateWithRepos.Api.Endpoints;
public static class GamesEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("api/games", async (IGamesRepository<Game> repository) =>
        {
            var games = await repository.FindAsync();
            return Results.Ok(games);
        })
        .WithName("Get Games")
        .WithOpenApi();
    }
}
