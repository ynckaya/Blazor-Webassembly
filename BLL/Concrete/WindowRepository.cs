using BLL.Base;
using DAL.DataContext;
using DAL.Interface;
using DAL.Models;

namespace BLL.Concrete;

public class WindowRepository: GenericRepository<Window>, IWindowRepository
{
    public WindowRepository(AppDbContext context): base(context) {}
}