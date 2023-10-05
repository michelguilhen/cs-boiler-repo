using System.Linq.Expressions;

namespace BoilerPlateWithRepos.Api.Data.Repositories.Common;
public interface IGenericRepository<T> where T : class
{
    Task<T?> FindByIdAsync(Guid id);
    Task<List<T>> FindAsync(Expression<Func<T, bool>>? expression = null);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(Guid id);
}
