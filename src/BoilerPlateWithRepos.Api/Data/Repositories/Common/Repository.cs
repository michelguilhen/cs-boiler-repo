using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoilerPlateWithRepos.Api.Data.Repositories.Common;
public class Repository<TEntity>: IRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<TEntity> _entities;

    public Repository(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _entities = context.Set<TEntity>();
    }

    public virtual async Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>>? expression = null)
    {
        var query = _entities.AsQueryable();
        if (expression is not null)
        {
            query = query.Where(expression);
        }
        return await query.ToListAsync();
    }

    public virtual async Task<TEntity?> FindByIdAsync(Guid id)
    {
        var entity = await _entities.FindAsync(id);
        return entity;
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        await _entities.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        _entities.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        var entity = await FindByIdAsync(id);
        if (entity is null)
        {
            return;
        }
        _entities.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
