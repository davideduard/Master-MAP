using David_Eduard_Lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace David_Eduard_Lab1.Data;

public static class DbInitializer
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new LibraryContext(serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
        {
            if (context.Book.Any())
            {
                return;
            }
            
            context.Book.AddRange(
                new Book{Title="Baltagul",Price=Decimal.Parse("22")},
                new Book{Title="Enigma Otiliei", Price=Decimal.Parse("18")},
                new Book{Title="Maytrei", Price=Decimal.Parse("27")}
                );
            
            context.Author.AddRange(
                new Author{FirstName = "Mihail", LastName = "Sadoveanu"},
                new Author{FirstName = "George", LastName = "Calinescu"},
                new Author{FirstName = "Mircea", LastName = "Eliade"}
                );
            
            context.Genre.AddRange(
                new Genre { Name="Roman"},
                new Genre { Name = "Nuvela" },
                new Genre { Name = "Poezie" }
            );
            context.Customer.AddRange(
                new Customer
                {
                    Name = "Popescu Marcela",
                    Address = "Str. Plopilor, nr. 24",
                    BirthDate = DateTime.SpecifyKind(DateTime.Parse("1979-09-01"), DateTimeKind.Utc)
                },
                new Customer
                {
                    Name = "Mihailescu Cornel",
                    Address = "Str. Bucuresti, nr.45, ap. 2",
                    BirthDate = DateTime.SpecifyKind(DateTime.Parse("1969-07-08"), DateTimeKind.Utc)
                }
            );

            context.SaveChanges();
        }
    }
}