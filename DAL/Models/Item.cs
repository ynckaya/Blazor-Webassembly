using DAL.Base;

namespace DAL.Models;

public class Item : BaseEntity
{
    public string Type { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    
    public Guid WindowId { get; set; }
    public Window Window { get; set; }
}