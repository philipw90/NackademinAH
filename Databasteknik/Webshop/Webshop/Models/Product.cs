using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public int Storage { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual  List<ProductOrder> ProductOrders { get; set; }
        public override string ToString()
        {
            return Name + " (" + Brand + ")";
        }

    }
}
