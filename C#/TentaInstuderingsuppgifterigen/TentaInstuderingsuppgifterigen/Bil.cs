using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaInstuderingsuppgifterigen
{            //Övning 10

    // Skriv en default och en överlagrad konstruktor till klassen Bil som sätter värden på
    // alla properties i klassen. En Bil har ett regnr en årsmodell och ett märke. Det skall
    // även gå att skapa en instans utan att sätta properties direkt.
   public class Bil
    {
       public string Licenseplate { get; set; }
       public int Year { get; set; }
       public string Brand { get; set; }

       public Bil()
       {
           
       }

       public Bil(string licenseplate, int year, string brand)
       {
           Licenseplate = licenseplate;
           Year = year;
           Brand = brand;

       }

    }
}
