using BoilerPlateWithRepos.Api.Data.Repositories.Common;
using BoilerPlateWithRepos.Api.Data.Repositories.Interfaces;
using BoilerPlateWithRepos.Api.Entities;
using System;
using System.Linq.Expressions;

namespace BoilerPlateWithRepos.Api.Data.Repositories;

public class GamesRepository : Repository<Game>, IGamesRepository
{
    public GamesRepository(AppDbContext db) : base(db)
    {
    }

    //public override async Task<List<Game>> FindAsync(Expression<Func<Game, bool>>? expression)
    //{
    //    await Task.Delay(100);
    //    throw new NotImplementedException();
    //}
}
