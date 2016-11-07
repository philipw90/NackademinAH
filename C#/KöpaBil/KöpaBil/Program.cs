using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KöpaBil
{
    //
    //    Köpa bil
    //Skapa en applikation som kan användas vid inköp av t ex en bil.
    //Applikationen ska ha en ”Order”-klass, ”Produkt”-klass, ”User”-klass och en ”Delar”-klass.
    //I varje order ska man kunna spara minst en produkt, man ska också kunna ta ut
    //leveransdatum och totalpris.Varje produkt har en lista av delar, pris samt en
    //beställare (User). Delar-klassen har egenskaperna ”Namn” ,”Pris” och ”Leveransdatum”.
    //User-klassen har egenskaperna ”Namn” och ”Epost”.
   public class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User
            {
                Epost = "Andre.holmlund@gmail.com",
                Namn = "Andre Holmlund"
            };

            Delar del = new Delar
            {
                Namn = " Avgasrör",
                Pris = 99.9,
                Leveransdatum = DateTime.Today.AddDays(4)
            };

            Delar del2 = new Delar
            {
                Namn = "Blinkers",
                Pris = 59.9,
                Leveransdatum = DateTime.Today.AddDays(3)
            };


            Produkt produkt = new Produkt();


            produkt.Delar.Add(del);
            produkt.Delar.Add(del2);

            Produkt produkt2 = new Produkt
            {
                Delar = 
            }

            

        }
    }
}
