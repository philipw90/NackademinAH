using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace KöpaBil
{    //    Köpa bil
     //Skapa en applikation som kan användas vid inköp av t ex en bil.
     //Applikationen ska ha en ”Order”-klass, ”Produkt”-klass, ”User”-klass och en ”Delar”-klass.
     //I varje order ska man kunna spara minst en produkt, man ska också kunna ta ut
     //leveransdatum och totalpris.Varje produkt har en lista av delar, pris samt en
     //beställare (User). Delar-klassen har egenskaperna ”Namn” ,”Pris” och ”Leveransdatum”.
     //User-klassen har egenskaperna ”Namn” och ”Epost”.
    public class Order
    {
        public static Produkt Produkt { get; set; }
        public User Beställare { get; set; }

        public static double TotalPris()
        {
            var pris = Produkt.Pris;

            foreach (var item in Produkt.Delar)
            {
                pris += item.Pris;
            }

            return pris;

        }

        public static Delar Leveransdatum()
        {
            var senaste = Produkt.Delar.OrderBy(x => x.Leveransdatum).FirstOrDefault();

            return senaste;
        }
    }
}
