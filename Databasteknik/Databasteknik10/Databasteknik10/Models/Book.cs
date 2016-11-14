using System.Collections.Generic;

namespace Databasteknik10.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<BookLoan> BookLoans  { get; set; }

    }
}