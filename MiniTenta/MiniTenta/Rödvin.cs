using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MiniTenta
{
    public class Rödvin : Dryck
    {
        public string Distrikt { get; set; }
        public override double Pris()
        {
            var pris = 100*1.25;
            return pris;
        }
    }
}
