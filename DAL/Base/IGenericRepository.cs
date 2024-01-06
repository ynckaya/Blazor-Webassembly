using System.Linq.Expressions;

namespace DAL.Base;

public interface IGenericRepository<T> where T: class  
{
    public Task<List<T>> GetAll();
    public Task<T?> GetById(Guid id);
    public Task Add(T entity);
    public Task Remove(Guid id);
    public Task Update(Guid id, T entity);
    public Task<T?> FindByFilter(Expression<Func<T, bool>> expression);
}