using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext;

public class AppDbContext : DbContext
{   
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Order>? Orders { get; set; }
    public DbSet<Window>? Windows { get; set; }
    public DbSet<Item>? Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configures one-to-many relationship
        modelBuilder.Entity<Window>()
            .HasOne(a => a.Order)
            .WithMany(a => a.Windows)
            .HasForeignKey(a => a.OrderId);
        
        modelBuilder.Entity<Item>()
            .HasOne(a => a.Window)
            .WithMany(a => a.Items)
            .HasForeignKey(a => a.WindowId);
        
        // Orders
        modelBuilder.Entity<Order>().HasData(new Order
        {
            Id = new Guid("B45BA972-743F-4EEC-9E90-4F95B8F5E4EF"),
            Name = "New York Building 1",
            State = "NY"
        });
        
        modelBuilder.Entity<Order>().HasData(new Order
        {
            Id = new Guid("FBA58D08-0EF0-4242-8D2B-86E9FC75613B"),
            Name = "California Hotel AJK",
            State = "CA"
        });
        
        // Windows of New York Building 1
        modelBuilder.Entity<Window>().HasData(new Window
        {
            Id = new Guid("0ACBCE03-0400-4FFC-AC99-C6409A12C092"),
            Name = "A51",
            QuantityOfWindows = 4,
            OrderId = new Guid("B45BA972-743F-4EEC-9E90-4F95B8F5E4EF")
        });
        
        modelBuilder.Entity<Window>().HasData(new Window
        {
            Id = new Guid("35EA7FD9-C332-4A92-8018-83850C9B6325"),
            Name = "C Zone 5",
            QuantityOfWindows = 2,
            OrderId = new Guid("B45BA972-743F-4EEC-9E90-4F95B8F5E4EF")
        });
        
        // Windows of California Hotel AJK
        modelBuilder.Entity<Window>().HasData(new Window
        {
            Id = new Guid("BD266222-A2CF-4E2D-93ED-4FD18AE0B3AD"),
            Name = "GLB",
            QuantityOfWindows = 3,
            OrderId = new Guid("FBA58D08-0EF0-4242-8D2B-86E9FC75613B")
        });
        
        modelBuilder.Entity<Window>().HasData(new Window
        {
            Id = new Guid("0B236432-92BE-4890-BDC5-84A27279B1D3"),
            Name = "OHF",
            QuantityOfWindows = 10,
            OrderId = new Guid("FBA58D08-0EF0-4242-8D2B-86E9FC75613B")
        });
        
        // Items of A51
        modelBuilder.Entity<Item>().HasData(new Item
        {
            Id = new Guid("6F863BAD-29A7-42BC-B24B-FBB7DB7B8EC4"),
            Type = "Doors",
            Width = 1200,
            Height = 1850,
            WindowId = new Guid("0ACBCE03-0400-4FFC-AC99-C6409A12C092")
        });
        modelBuilder.Entity<Item>().HasData(new Item
        {
            Id = new Guid("16518B0A-3555-4FBA-B84C-55D97EBA9DCC"),
            Type = "Window",
            Width = 800,
            Height = 1850,
            WindowId = new Guid("0ACBCE03-0400-4FFC-AC99-C6409A12C092")
        });
        modelBuilder.Entity<Item>().HasData(new Item
        {
            Id = new Guid("D95D2178-2172-4D34-B6CB-1D698BC85068"),
            Type = "Window",
            Width = 700,
            Height = 1850,
            WindowId = new Guid("0ACBCE03-0400-4FFC-AC99-C6409A12C092")
        });
        
        // Items of A51
        modelBuilder.Entity<Item>().HasData(new Item
        {
            Id = new Guid("66C55954-D519-4E46-B070-F1CE148E68D5"),
            Type = "Window",
            Width = 1500,
            Height = 2000,
            WindowId = new Guid("35EA7FD9-C332-4A92-8018-83850C9B6325")
        });
        
        // Items of GLB
        modelBuilder.Entity<Item>().HasData(new Item
        {
            Id = new Guid("737274FD-6931-413C-8AB9-CF2855A307BD"),
            Type = "Doors",
            Width = 1400,
            Height = 2200,
            WindowId = new Guid("BD266222-A2CF-4E2D-93ED-4FD18AE0B3AD")
        });
        modelBuilder.Entity<Item>().HasData(new Item
        {
            Id = new Guid("74D82DF8-45DD-422B-B802-17EC1CC13033"),
            Type = "Window",
            Width = 600,
            Height = 2200,
            WindowId = new Guid("BD266222-A2CF-4E2D-93ED-4FD18AE0B3AD")
        });
        
        // Items of OHF
        modelBuilder.Entity<Item>().HasData(new Item
        {
            Id = new Guid("B6C00115-5A33-4C90-B8DA-C81D0C8D53AB"),
            Type = "Doors",
            Width = 1500,
            Height = 2000,
            WindowId = new Guid("0B236432-92BE-4890-BDC5-84A27279B1D3")
        });
        modelBuilder.Entity<Item>().HasData(new Item
        {
            Id = new Guid("BE3D65FD-E324-423D-87C2-D528043C7782"),
            Type = "Window",
            Width = 1500,
            Height = 2000,
            WindowId = new Guid("0B236432-92BE-4890-BDC5-84A27279B1D3")
        });
    }
}