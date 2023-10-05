using BoilerPlateWithRepos.Api.Data.Repositories.Common;
using BoilerPlateWithRepos.Api.Data.Repositories.Interfaces;

namespace BoilerPlateWithRepos.Api.Data.Repositories;

public class GamesRepository<Game> : GenericRepository<Game>, IGamesRepository<Game> where Game : class
{
    public GamesRepository(AppDbContext db) : base(db)
    {
    }
}
