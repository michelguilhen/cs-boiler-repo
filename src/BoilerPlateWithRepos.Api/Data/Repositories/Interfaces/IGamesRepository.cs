using BoilerPlateWithRepos.Api.Data.Repositories.Common;

namespace BoilerPlateWithRepos.Api.Data.Repositories.Interfaces
{
    public interface IGamesRepository<Game> : IGenericRepository<Game> where Game : class
    {
    }
}
