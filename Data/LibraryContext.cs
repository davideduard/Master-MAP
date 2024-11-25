using Microsoft.EntityFrameworkCore;
using David_Eduard_Lab1.Models;

namespace David_Eduard_Lab1.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Genre> Genre { get; set; } = default!;
        public DbSet<Author> Author { get; set; } = default!;
    }
}
