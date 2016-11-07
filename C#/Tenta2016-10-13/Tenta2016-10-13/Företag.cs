using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tenta2016_10_13
{
public class Företag
{
public string Namn { get; set; }
public string Gatuadress { get; set; }
public string Ort { get; set; }
public string Webbadress { get; set; }
public Person Ägare { get; set; }
public List<Person> Anställda { get; set; } = new List<Person>();

public Företag(string namn, string gatuadress, string ort, string webbadress, Person person)
{
    Namn = namn;
    Gatuadress = gatuadress;
    Ort = ort;
    Webbadress = webbadress;
    Ägare = person;
}

public void NyAnställd(Person person)
{
    Anställda.Add(person);
}
}
}
