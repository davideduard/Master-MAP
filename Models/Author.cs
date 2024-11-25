using System.ComponentModel.DataAnnotations;

namespace David_Eduard_Lab1.Models;

public class Author
{
    [Key]
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}