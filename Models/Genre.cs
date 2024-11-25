using System.ComponentModel.DataAnnotations;

namespace David_Eduard_Lab1.Models;

public class Genre
{
    [Key]
    public int GenreId { get; set; }
    public string Name { get; set; }
}