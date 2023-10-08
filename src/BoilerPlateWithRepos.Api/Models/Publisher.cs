namespace BoilerPlateWithRepos.Api.Models;
public class Publisher
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public List<Game> Games { get; set; } = default!;
}
