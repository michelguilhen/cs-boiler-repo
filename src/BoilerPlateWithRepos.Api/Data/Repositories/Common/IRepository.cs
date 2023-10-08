using System.Linq.Expressions;
using BoilerPlateWithRepos.Api.Entities;

namespace BoilerPlateWithRepos.Api.Data.Repositories.Common;
public interface IRepository<TEntity> where TEntity : class
{
    Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>>? expression = null);
    Task<TEntity?> FindByIdAsync(Guid id);
    Task<TEntity> CreateAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task DeleteAsync(Guid id);
}
