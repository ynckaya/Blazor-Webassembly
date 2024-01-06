using BLL.Concrete;
using DAL.DataContext;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Extensions;

public static class ExtensionServices
{
    public static IServiceCollection LoadDalExtension(this IServiceCollection services, IConfiguration configure)
    {
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(configure.GetConnectionString("DefaultConnection")));
        
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IWindowRepository, WindowRepository>();
        services.AddScoped<IItemRepository, ItemRepository>();
        
        return services;
    }
}