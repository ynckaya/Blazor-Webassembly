using BLL.Base;
using DAL.DataContext;
using DAL.Interface;
using DAL.Models;

namespace BLL.Concrete;

public class ItemRepository: GenericRepository<Item>, IItemRepository
{
    public ItemRepository(AppDbContext context): base(context) {}
}