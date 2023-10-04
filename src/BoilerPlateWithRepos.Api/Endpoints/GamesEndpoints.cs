namespace BoilerPlateWithRepos.Api.Endpoints
{
    public static class GamesEndpoints
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("api/games", () =>
            {
                return new string[] { "Elden Ring", "StarCraft" };
            })
            .WithName("Get Games")
            .WithOpenApi();
        }
    }
}
