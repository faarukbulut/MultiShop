using System.Linq.Expressions;

namespace MultiShop.Order.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
