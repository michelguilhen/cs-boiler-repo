using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateWithRepos.Api.Data.Repositories.Common;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext _db;

    public GenericRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _db.Set<T>().AddAsync(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var entity = await FindByIdAsync(id);
        if (entity is null)
        {
            return false;
        }
        _db.Set<T>().Remove(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<List<T>> FindAsync(Expression<Func<T, bool>>? expression = null)
    {
        var query = _db.Set<T>().AsQueryable();
        if (expression is not null)
        {
            query = query.Where(expression);
        }
        return await query.ToListAsync();
    }

    public async Task<T?> FindByIdAsync(Guid id)
    {
        var entity = await _db.Set<T>().FindAsync(id);
        return entity;
    }

    public Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
