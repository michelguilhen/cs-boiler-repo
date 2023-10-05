namespace BoilerPlateWithRepos.Api.Entities;
public class Game
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
}
