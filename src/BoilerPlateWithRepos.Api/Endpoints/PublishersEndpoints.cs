using BoilerPlateWithRepos.Api.Data.Repositories.Interfaces;

namespace BoilerPlateWithRepos.Api.Endpoints;
public static class PublishersEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("api/publishers", async (IPublishersRepository repository) =>
        {
            var publishers = await repository.FindAsync();
            return Results.Ok(publishers);
        });
    }
}