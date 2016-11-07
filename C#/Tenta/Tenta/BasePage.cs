using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta
{
    public abstract class BasePage
    {
        public string Rubrik { get; set; }
        public string Ingress { get; set; }
        public Guid SidId
        {
            get { return Guid.NewGuid(); }
        }

    }
}
