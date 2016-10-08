using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtension_metoder.Extention
{
    public static class Extensionmetoder
    {
        // Övning 1
        //Skapa en Extension Method för String.Den skall ta emot en sträng och kontrollera om värdet i
        //den är ett tal. Metoden skall returnera true om strängen går att göra om till ett tal och false
        //annars.Döp den till IsNumeric. 

        //public static bool IsNumeric(this string input)
        //{

        //    return input.Any(char.IsDigit);
        //}

        // Övning 2

        // Skapa en Extension Method för String. Den skall ta emot en sträng med olika ord som särskiljs av
        // mellanslag. Metoden skall göra om första bokstaven i varje ord så att den blir stor. Döp den till
        // UppercaseWordFirstLetter.
        // string namn = "nackademin yrkeshögskola";
        // namn = namn.UppercaseWordFirstLetter(); //Skall ge "Nackademin Yrkeshögskola" 

        //public static string UppercaseWordFirstLetter(this string input)
        //{

        //    string s = new CultureInfo("").TextInfo.ToTitleCase(input);

        //    return s;
        //}


        //Övning 3

        // Skriv en Extension Method för DateTime, som returnerar datumet för sista dagen i månaden
        // för det datum man använder metoden på:
        // var lastDate = DateTime.Now.GetLastDateOfMonth();
        // Om det t ex är den 11 oktober 2015 när koden ovan körs, så returneras ett datumobjekt som
        // innehåller den 31 oktober 2015. Tänk på att metoden måsta klara skott-år(dvs februari med
        // 29 dagar). 

        //public static DateTime GetLastDateOfMonth(this DateTime dateTime)
        //{
        //    DateTime now = DateTime.Now;
        //    var date = new DateTime(now.Year, now.Month, 1);
        //    var lastDate = date.AddMonths(1).AddDays(-1);
        //    return lastDate;
        //}

        //Övning 4

        // Skapa en extension method som du döper till ListToString.Den skall ta emot en lista med
        // strängar och ”platta till den” så den returnerar en kommaseparerad sträng med alla värden i
        // listan.Använd StringBuilder klassen för att skapa strängen.

        //public static string ListToString(this List<string> stringList)
        //{
        //    StringBuilder sbBuilder = new StringBuilder();

        //    foreach (var lists in stringList)
        //    {
        //        sbBuilder.Append(lists).Append(",");
        //    }
        //    string resultFromStringBuilder = sbBuilder.ToString();

        //    return resultFromStringBuilder;
        //}

        //Övning 5

        // Skapa en extension method. Den skall vara en overload på metoden Add som finns för en lista
        // av integers.Den vanliga Add metoden tar bara ett tal i taget. Den metod som du skall skapa skall
        // ta en array med valfritt antal tal och lägga in alla samtidigt i listan. Ett tips är att använda params
        // nyckelordet.Metoden skall kunna anropas på detta sätt.
        // List<int> tal = new List<int>(); 
        // tal.Add(7, 8, 9, 10);

        //public static void Add(this List<int> numbers,params int[] numberArray)
        //{
        //    foreach (var integers in numberArray)
        //    {
        //        numbers.Add(integers);
        //    }

        //}

    }
}
