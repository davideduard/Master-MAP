using System.ComponentModel.DataAnnotations;

namespace David_Eduard_Lab1.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime BirthDate { get; set; }
    
    public ICollection<Order>? Orders { get; set; }
}