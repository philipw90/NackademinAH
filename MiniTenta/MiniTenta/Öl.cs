using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTenta
{
    public class Öl : Dryck
    {
        public bool TypÄrIpa { get; set; }
        public override double Pris()
        {
            var pris = 15*1.12;
            return pris;
        }
    }
}
