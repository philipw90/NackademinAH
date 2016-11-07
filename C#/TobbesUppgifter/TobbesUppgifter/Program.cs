using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TobbesUppgifter
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Övning 1
            // Skapa en array och generera 100 tal som du lägger i arrayen. Visa hur man kan ta fram medelvärdet för
            // alla jämna tal som finns i arrayen.Visa via programkod hur detta kan göras utan att använda LINQ
            // eller lambda uttryck.

            //int sum = 0;
            //var count = 0;

            //int[] myArray = new int[100];

            //for (int i = 0; i < 100; i++)
            //{
            //    myArray[i] = i;
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += myArray[i];
            //        count++;
            //    }
            //}

            //var avreage = sum / count;
            //Console.WriteLine(avreage);

            //}

            // Övning 2
            // Skapa en metod som tar emot ett födelsedatum för en person och ta emot det som en sträng.
            // metoden skall via kod räkan ut hur många år gammal personen är samt hur många år det är tills
            //personen blir pensionär. utgå från att man blir pensionär vid 65års ålder.

            // koden skall fungera för alla födelsedatum och den skall fungera även när aktuellt år ändras.
            // ???????? kör när som helst och ändå ge rätt svar). Visa via kod hur detta görs.

            //public static void AgeAndTimeToRetirement(string birthday)
            //{
            //    var date = birthday;

            //    DateTime dateTime = Convert.ToDateTime(date);

            //    var today = DateTime.Today;
            //    var age = today.Year - dateTime.Year;
            //    if (dateTime > today.AddYears(-age)) age--;

            //    Console.WriteLine("Personen är "+ age + " År gammal");

            //    Console.WriteLine("Antal år kvar till pension " + (65- age));
            //
            //AgeAndTimeToRetirement("89/03/02");


            //Övning 3

            //Du har två metoder Start() och Beräkna().Från Start() skall du anropa Beräkna() och skicka
            //med strängarna varde1 och varde2 som inparametrar.I Beräkna() kontrollerar du om varde1
            //och varde2 är tal.Om de är tal multiplicerar du talen och returnerar dem som en double.Om
            //de inte är tal returnerar du - 1.

            //public static void Start()
            //{
            //    var varde1 = "6";
            //    var varde2 = "6";

            //    Console.WriteLine(Beräkna(varde1, varde1));

            //}

            //public static double Beräkna(string varde1, string varde2)
            //{

            //    //var input1 = double.Parse(varde1);
            //    //var input2 = double.Parse(varde2);

            //    try
            //    {
            //        var input1 = double.Parse(varde1);
            //        var input2 = double.Parse(varde2);

            //        var result = (input1 * input2);
            //        return result;
            //    }
            //    catch (Exception)
            //    {
            //        return -1;
            //    }

            //}


            //Övning 4

            //  Utgå från följande array:

            //      double[] housePriceInDollars = { 3.4, 5.2, 1.2, 0.7, 2.6, 2.7, 3.0 };

            // Arrayen visar huspriserna i miljoner dollar på en gata i Brooklyn.Ta nu med hjälp av LINQ
            // (inga loopar är tillåtna) fram en ny array som du döper till housePriceInSEK där du konverterar alla priser till
            // kronor.Vi utgår i uppgiften från en växelkurs på 1 dollar mot 8 kronor.
            // såhär skall det se ut: { "27.2, 41.6, 9.6 osv...
           
            
        }

        //public static void DollarsBiatch()
        //{
        //    double[] housePriceInDollars = { 3.4, 5.2, 1.2, 0.7, 2.6, 2.7, 3.0 };

        //    var housePriceInSEK = housePriceInDollars.Select(x => x * 8).ToArray();

        //    foreach (var item in housePriceInSEK)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


        // Övning 5

        //Från nedanstående array. Du måste använda LINQ. Ta fram alla jämna tal från denna array och
        // sortera talen i storleksordning med det största talet först.Resultatet får INTE innehålla dubbletter.
        //Visa med kod hur detta kan göras.


        //public static void NyMeotd()
        //{
        //    int[] tal = { 9, 6, 4, 7, 5, 1, 3, 4, 6, 2, 5, 74, 4, 2, 88 };
        //    tal.OrderByDescending(x=> x).Distinct().ToList().ForEach(Console.WriteLine);
        //}

        //Övning 6  

        //  Skapa en klass Fest som har egenskaperna(properties) Namn, Beskrivning, Starttid, Sluttid, Lokalkostnad och Plats.
        //  Skapa ytterligare en klass Deltagare med egenskaperna Förnamn, Efternamn samt Ålder.
        //  Lägg sedan till ytterligare en egenskap (property) som du döper till Värd i din Fest-klass.
        //  Den skall vara av typen Deltagare.
        //  Skapa slutligen kod som instansierar en ny Fest och en ny Deltagare och lägger Deltagaren som värd till festen.

        //Carls superuppgift

        //public static void Carlsuppgifter()
        //{
        //    var myString = "Jag är home";

        //    var mystringSplitted = myString.Split(' ');

        //    StringBuilder stringBuilder = new StringBuilder();

        //    foreach (var item in mystringSplitted)
        //    {
        //        stringBuilder.Append("k" + item.Substring(1) + " ");
        //    }

        //    Console.WriteLine(stringBuilder.ToString());

        //}


    }

}
