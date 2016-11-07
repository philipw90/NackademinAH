using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2016_10_13
{
public abstract class Fastighet
{
public int Boyta { get; set; }
public int Taxeringsvärde { get; set; }
public abstract double Fastighetsavgift();
}
    
}
