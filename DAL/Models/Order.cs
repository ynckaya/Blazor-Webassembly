using DAL.Base;

namespace DAL.Models;

public class Order : BaseEntity
{
    public string Name { get; set; }
    public string State { get; set; } 
    public IEnumerable<Window> Windows { get; set; }
}