using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Windows.Forms.VisualStyles;
using Databasteknik10.Models;

namespace Databasteknik10
{
    internal class LibraryDbInitializer : DropCreateDatabaseIfModelChanges<LibraryDbContext>
    {
        protected override void Seed(LibraryDbContext context)
        {
            context.Categories.AddOrUpdate(x=>x.Id,
                new Category{ Name = "Horror"},
                new Category { Name = "Commedy"}
            );
            context.Books.AddOrUpdate(x=>x.ISBN,
                new Book { ISBN = "121212121212",
                    Author = "John Doe",
                    CategoryId = 1,
                    Name = "MyHorrorBook",
                    Pages = 993
                }
            );
        }
    }
}