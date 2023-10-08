using BoilerPlateWithRepos.Api.Data.Repositories.Common;
using BoilerPlateWithRepos.Api.Data.Repositories.Interfaces;
using BoilerPlateWithRepos.Api.Models;

namespace BoilerPlateWithRepos.Api.Data.Repositories;
public class PublishersRepository : Repository<Publisher>, IPublishersRepository
{
    public PublishersRepository(AppDbContext context) : base(context)
    {
    }
}
