using System.ComponentModel.DataAnnotations;

namespace David_Eduard_Lab1.Models;

public class Order
{
    [Key]
    public int OrderId { get; set; }
    
    public int? CustomerId { get; set; }
    public int? BookId { get; set; }
    
    public Customer? Customer { get; set; }
    public Book? Book { get; set; }
}