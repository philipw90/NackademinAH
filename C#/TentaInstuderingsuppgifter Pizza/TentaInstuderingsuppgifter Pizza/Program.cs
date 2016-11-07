using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaInstuderingsuppgifter_Pizza
{
    public class Program
    {
        //Övning 16
        //  Skapa en klass Pizza.I klassen ska det finnas tre egenskaper: Namn, Pris och en lista på
        //  ingredienser. Skapa tre inparametrar i konstruktorn där du skickar in dessa egenskaper. Klassen Ingrediens ska ha egenskapen Namn. 
        //Övning 17
        // Skapa upp två pizzor som instansierar klassen Pizza.De ska heta Vesuvio och Capriciosa.
        // Vesuvio ska kosta 70 sek och har ingredienserna ost, tomat och skinka medans
        // Capriciossa består av ost, tomat, skinka och champinjoner och kostar 75 sek.Skapa upp
        // klassen Order som har en lista av pizzor som den enda egenskapen. Lägg till dina två pizzor
        // till en order och hämta sedan ut totalpriset på ordern.
        static void Main(string[] args)
        {

            var ingrediensForVesuvio = new List<Ingrediens>()
            {
                new Ingrediens {Namn = "ost"},
                new Ingrediens {Namn = "tomat"},
                new Ingrediens {Namn = "skinka"},
            };

            var ingrediensForCapriciossa = new List<Ingrediens>
            {
                new Ingrediens {Namn = "ost"},
                new Ingrediens {Namn = "tomat"},
                new Ingrediens {Namn = "skinka"},
                new Ingrediens {Namn = "champinjoner"}
            };



            Pizza vesuvio = new Pizza ("Vesuvio", 70, ingrediensForVesuvio);
            Pizza capriciosa = new Pizza("Capriciosa",75, ingrediensForCapriciossa);


            Order order = new Order();
            order.Pizzor.Add(vesuvio);
            order.Pizzor.Add(capriciosa);

            var pris = order.Pizzor.Sum(x => x.Pris);

            Console.WriteLine(pris);

        }
    }
}
