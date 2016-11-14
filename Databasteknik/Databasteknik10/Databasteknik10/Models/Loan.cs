using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasteknik10.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual List<BookLoan> BookLoans { get; set; }

    }
}
