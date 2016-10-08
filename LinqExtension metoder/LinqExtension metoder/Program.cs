using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExtension_metoder.Extention;

namespace LinqExtension_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Övning 1
            //var myString = "shoba";

            //bool exmetod = myString.IsNumeric();

            //if (exmetod == true)
            //{
            //    Console.WriteLine("Strängen går att göra om till en int");
            //}
            //if (exmetod==false)
            //{
            //    Console.WriteLine("Stängen går inte att göra om till en int");
            //}

            // Övning 2

            // Skapa en Extension Method för String. Den skall ta emot en sträng med olika ord som särskiljs av
            // mellanslag. Metoden skall göra om första bokstaven i varje ord så att den blir stor. Döp den till
            // UppercaseWordFirstLetter.
            // string namn = "nackademin yrkeshögskola";
            // namn = namn.UppercaseWordFirstLetter(); //Skall ge "Nackademin Yrkeshögskola"  

            //var name = "nackademin yrkeshögskola";
            //name = name.UppercaseWordFirstLetter();
            //Console.WriteLine(name);


            //Övning 3

            // Skriv en Extension Method för DateTime, som returnerar datumet för sista dagen i månaden
            // för det datum man använder metoden på:
            // var lastDate = DateTime.Now.GetLastDateOfMonth();
            // Om det t ex är den 11 oktober 2015 när koden ovan körs, så returneras ett datumobjekt som
            // innehåller den 31 oktober 2015. Tänk på att metoden måsta klara skott-år(dvs februari med
            // 29 dagar). 


            //var lastDate = DateTime.Now.GetLastDateOfMonth();

            //Console.WriteLine(lastDate);


            //Övning 4

            // Skapa en extension method som du döper till ListToString.Den skall ta emot en lista med
            // strängar och ”platta till den” så den returnerar en kommaseparerad sträng med alla värden i
            // listan.Använd StringBuilder klassen för att skapa strängen.

            //List<string> stringList = new List<string>();
            //stringList.Add("Devon Rex");
            //stringList.Add("Manx"); 
            //stringList.Add("Munchkin"); 
            //stringList.Add("American Curl");
            //stringList.Add("German Rex");

            //string cats = stringList.ListToString();

            //Console.WriteLine(cats);

            //Övning 5

            // Skapa en extension method. Den skall vara en overload på metoden Add som finns för en lista
            // av integers.Den vanliga Add metoden tar bara ett tal i taget. Den metod som du skall skapa skall
            // ta en array med valfritt antal tal och lägga in alla samtidigt i listan. Ett tips är att använda params
            // nyckelordet.Metoden skall kunna anropas på detta sätt.
            // List<int> tal = new List<int>();
            //            tal.Add(7, 8, 9, 10);

            //List<int> nums = new List<int>();
            //nums.Add(7, 8, 9, 10, 11, 12, 13, 14, 13);


            //foreach (var VARIABLE in nums)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

        }
    }
}
