using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2016_10_13
{
public class Lägenhet : Fastighet
{
public int Lägenhetsnummer { get; set; }
public override double Fastighetsavgift()
{
var fastighetsavgift = Taxeringsvärde * 0.3;

if (fastighetsavgift > 1217)
{
return fastighetsavgift;
}
else
{
return 1217;
}
}
}
}
