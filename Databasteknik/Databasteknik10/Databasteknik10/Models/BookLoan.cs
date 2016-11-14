using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasteknik10.Models
{
    public class BookLoan
    {
        [Key]
        [Column(Order = 1)]
        public int BookId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int LoanId { get; set; }
        public int Quantity { get; set; }

        public virtual Book Book { get; set; }
        public virtual List<BookLoan> BookLoans { get; set; }

    }
}
