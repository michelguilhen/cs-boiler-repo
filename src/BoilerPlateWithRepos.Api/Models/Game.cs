namespace BoilerPlateWithRepos.Api.Models;
public class Game
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public Publisher Publisher { get; set; } = default!;
}
