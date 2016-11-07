using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2016_10_13
{
public class Villa : Fastighet
{
public int TomtYta { get; set; }
public override double Fastighetsavgift()
{
var fastighetsavgift = Taxeringsvärde* 0.75;

if (fastighetsavgift> 7112)
{
    return fastighetsavgift;
}
else
{
    return 7112;
}

}
}
}
