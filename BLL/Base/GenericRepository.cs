using System.Linq.Expressions;
using DAL.Base;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;

namespace BLL.Base;

public class GenericRepository<T> : IGenericRepository<T> where T: class
{
    protected readonly AppDbContext _context;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<T>> GetAll()
    {
        try
        {
            return await _context.Set<T>().ToListAsync();
        }
        catch (Exception e)
        {
            throw new Exception("Failed to get item");
        }
    }
    public async Task<T?> GetById(Guid id)
    {
        try
        {
            var item = await _context.Set<T>().FindAsync(id);

            if (item != null)
            {
                return item;
            }
            else
            {
                throw new Exception("Failed to find item");
            }
        }
        catch (Exception e)
        {
            throw new Exception("Failed to get item");
        }
    }

    public async Task Add(T entity)
    {
        try
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception("Failed to create " + entity.GetType());
        }
    }

    public async Task Remove(Guid id)
    {
        try
        {
            var item = await GetById(id);
            
            if (item != null)
            {
                _context.Set<T>().Remove(item);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Item does not exist");
            }
        }
        catch (Exception e)
        {
            throw new Exception("Failed to delete item");
        }
    }

    public async Task Update(Guid id, T entity)
    {
        try
        {
            var item = await GetById(id);
            
            if (item != null)
            {
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Item does not exist");
            }
        }
        catch (Exception e)
        {
            throw new Exception("Item does not update");
        }
    }

    public async Task<T?> FindByFilter(Expression<Func<T, bool>> expression)
    {
        return await _context.Set<T>().Where(expression).SingleOrDefaultAsync();
    }
}