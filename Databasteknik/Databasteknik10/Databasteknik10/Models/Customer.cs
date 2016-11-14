using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasteknik10.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Loan> Loans { get; set; }
        public string  Phone { get; set; }
         
    }
}