using System.ComponentModel.DataAnnotations;

namespace David_Eduard_Lab1.Models;

public class Book
{
    [Key]
    public int ID { get; set; }
    
    public string Title { get; set; }
    public int? AuthorId { get; set; }
    public Author? Author { get; set; }
    public decimal Price { get; set; }
    public int? GenreID { get; set; }
    public Genre? Genre { get; set; }
    
    public ICollection<Order>? Orders { get; set; }
}