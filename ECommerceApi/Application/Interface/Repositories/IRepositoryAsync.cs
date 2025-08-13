using Domain.Entitties.Common;
using System.Linq.Expressions;

namespace Application.Interface.Repositories
{
    public interface IRepositoryAsync<T> where T : AuditableEntity, new()
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        // T Get(Guid id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<IList<T>> GetAllAsync();
        Task<List<T>> GetAllByIdsAsync(List<Guid> ids);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> expression);
        Task<IList<T>> GetAllByExpression(Expression<Func<T, bool>> expression);
    }
}
