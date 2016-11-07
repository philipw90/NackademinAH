using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaInstuderingsuppgifterigen
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Dogowner Dogowner { get; set; }  
    }
}
