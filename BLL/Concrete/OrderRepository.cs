using BLL.Base;
using DAL.DataContext;
using DAL.Interface;
using DAL.Models;

namespace BLL.Concrete;

public class OrderRepository: GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext context): base(context) {}
}