using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databasteknik10.Models;

namespace Databasteknik10
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext() : base("LibraryDbContext")
        {
            Database.SetInitializer(new LibraryDbInitializer());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }  


    }
}
