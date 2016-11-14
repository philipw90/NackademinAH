using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public virtual List<Product> Products { get; set; } 

        public override string ToString()
        {
            return Id + "(" + Name + ")";
        }
    }
}
