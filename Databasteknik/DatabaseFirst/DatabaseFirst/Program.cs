using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SkolaEntities())
            {

                Elev elev = new Elev
                {
                    Personnummer = "8603020410",
                    Fornamn = "Greger",
                    Efternamn = "Gregersson",
                    Epost = "Greger@gregersson.com",
                    Telefon = "0705134426",
                    Ort = "Jönköping",
                    Klasskod = db.Klass.Where(x => x.Namn == "Sharepoint").Select(z => z.Kod).Single()
                };

                db.Elev.Add(elev);

                db.SaveChanges();
            }
        }
    }

    //var antalElever = db.Elev.Count(x => x.Klass.Namn == "Java programmering");

    //Console.WriteLine($"Antal elever: {antalElever}");

    //foreach (var x in antalElever)
    //{
    //    Console.WriteLine($"{x.Namn}");

    //}
}
