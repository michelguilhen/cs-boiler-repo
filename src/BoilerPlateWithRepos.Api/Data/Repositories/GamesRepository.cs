using System.Linq.Expressions;
using BoilerPlateWithRepos.Api.Data.Repositories.Common;
using BoilerPlateWithRepos.Api.Data.Repositories.Interfaces;
using BoilerPlateWithRepos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateWithRepos.Api.Data.Repositories;
public class GamesRepository : Repository<Game>, IGamesRepository
{
    public GamesRepository(AppDbContext context) : base(context)
    {
    }

    public override async Task<List<Game>> FindAsync(Expression<Func<Game, bool>>? expression)
    {
        var query = _entities.AsQueryable();
        if (expression is not null)
        {
            query = _entities.Where(expression);
        }
        return await query.ToListAsync();
    }
}
