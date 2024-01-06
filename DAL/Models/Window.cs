using DAL.Base;

namespace DAL.Models;

public class Window : BaseEntity
{
    public string Name { get; set; }
    public int QuantityOfWindows { get; set; }
    
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    
    public IEnumerable<Item> Items { get; set; }
}