using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTenta
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Fråga 1

            // Fråga 1
            //Skapa en metod som kollar hur många dagar det är sedan Djurgårdens IF vann sitt senaste SM-guld i fotboll, datumet var 2005 - 10 - 23.
            // DjurgårdsMetoden();

            #endregion

            #region Fråga 2

            //Fråga 2
            // Skapa en metod som har en sträng som inparameter och som returnerar antalet versala(stora) bokstäver som förekommer i strängen.
            //Console.WriteLine(CapitalLetters("HeJa"));

            #endregion

            #region Fråga 3

            // Fråga 3
            //Skapa en extensionmetod till datatypen string. Den ska returnera strängen i bokstavsordning, dvs strängen ”koriander” ska bli ”adeiknorr”. Använd inte LINQ.
            //var myString = "koriander";
            //var sortedString = myString.AplpahbeticOrder();

            //Console.WriteLine(sortedString);

            #endregion

            #region Fråga 4

            //4.	Skapa klasserna Order och Maträtt. Order ska ha egenskapen Maträtter och metoden TotalPris. 
            //Klassen Maträtt har en konstruktor med parametrarna Namn och Pris, koppla dessa till klassens egenskaper. 
            //Instansiera en order och lägg till två maträtter. Returnera totalpriset på hela ordern. 


            //var kebab = new Maträtt("Kebab", 80);
            //var pizza = new Maträtt("Pizza", 75);

            //Order order1 = new Order();

            //order1.Maträtter.Add(pizza);
            //order1.Maträtter.Add(kebab);

            //Console.WriteLine(order1.TotalPris());

            #endregion

            #region Fråga 5

            // Fråga 5



            //Rödvin rödvin = new Rödvin();
            //Öl öl = new Öl();

            //var prisRövin = rödvin.Pris();
            //var prisÖl = öl.Pris();

            //Console.WriteLine("Pris rödvin är: " + prisRövin + " Pris öl är:  " + prisÖl);

            #endregion

            #region Fråga 6

            // Fråga 6
            //Skapa en metod som tar emot en lista av strängar. Sortera strängarna efter deras längd, kortast först, och returnera listan. Använd LINQ.

            //List<string> listan = new List<string> {"Heja", "Djurgården", "blaaaaaaaaaaaaa"};

            //var tempList = SortList(listan);

            //foreach (var item in tempList)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Fråga 1

            //Fråga 1
            //public static void DjurgårdsMetoden()
            //{
            //    DateTime date1 = new DateTime(2005, 10, 23);
            //    var date2 = DateTime.Today;

            //    var days = (date2 - date1).TotalDays;

            //    Console.WriteLine(days);
            //}

            #endregion

            #region Fråga 2

            //Fråga 2

            //public static string CapitalLetters(string input)
            //{
            //    var myString = input;

            //    var countCapitalLetters = string.Join(" ", myString).Count(char.IsUpper);

            //    return countCapitalLetters.ToString(char.IsUpper);

            // s.ToCharArray().Count()
            //}

            #endregion

            #region Fråga 6

            // Fråga 6
        }

        //public static List<string> SortList(List<string> sortedList)
        //{

        //    var myList = sortedList;

        //    var sortedName = myList.OrderBy(x => x.Length).ToList();

        //    return sortedName;

        //}

        #endregion
    }
}
}
