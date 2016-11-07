using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2016_10_13
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            #region Fråga 1

            //Console.WriteLine("Mata in ett vödelsedatum liknande 2005 , 10 ,23");

            //var birthdate = DateTime.Parse(Console.ReadLine());

            //var today = DateTime.Today;
            //var age = today.Year - birthdate.Year;
            //if (birthdate > today.AddYears(-age)) age--;
            //Console.WriteLine(age);





            #endregion

            #region Fråga 2

            //var myString = "Sex laxar i en laxask";

            //var mystringSplitted = myString.Split(' ');

            //StringBuilder stringBuilder = new StringBuilder();

            //foreach (var item in mystringSplitted)
            //{
            //    stringBuilder.Append("k" + item.Substring(1) + " ");
            //}

            //Console.WriteLine(stringBuilder.ToString());

            #endregion

            #region Fråga 3

            //Console.WriteLine(Fråga3(3, 2, 1));

            #endregion

            #region Fråga 3


            //        public static string Fråga3(int input1, int input2, int input3)
            //{
            //    var value1 = input1;
            //    var value2 = input2;
            //    var value3 = input3;

            //    if (value1 > value2 && value1 > value3)
            //    {
            //        var average = value1 + value2 + value3 / 3;
            //        var sum = value1 + value2 + value3;
            //        return "Medelvärdet är " + average + " Och summan är: " + sum;
            //    }
            //    else
            //    {
            //        var firstAndSecond = value1 * value2;
            //        var SecondAndThird = value2 * value3;
            //        return " Det första talet gånger det andra talet är: " + firstAndSecond +
            //                " Det andra talet gånger det trejde är: " + SecondAndThird;
            //    }

            //}



            #endregion

            #region Fråga 4 Företag

            Person person1 = new Person
            {
                Förnamn = "Carl",
                Efternamn = "Schéle",
                Personnummer = 19800302 - 0000
            };

            Företag företag1 = new Företag("Preem", "Vägen 18", "Stockholm", "www.preem.se", person1);

            Företag företag2 = new Företag
            {
                Namn = "Preem",
                Gatuadress = "Vägen",
                Ort = "Stockholm",
                Webbadress = "www.preem.se",
                Ägare = person1
            };

            #endregion

            #region Fråga 5 Företag

            Person person2 = new Person
            { Förnamn = "Andre", Efternamn = "Holmlund", Personnummer = 830203 - 0550 };

            Person person3 = new Person
            { Förnamn = "Andre", Efternamn = "Göransson", Personnummer = 830203 - 0550 };

            företag1.NyAnställd(person2);
            företag1.NyAnställd(person1);

            var antalAnställda = företag1.Anställda.Count;

            Console.WriteLine(antalAnställda);
        }



        #endregion

        #region Fråga 6

        Villa villa = new Villa { Taxeringsvärde = 100 };

        Lägenhet lägenhet = new Lägenhet { Taxeringsvärde = 10 };

        Console.WriteLine(villa.Fastighetsavgift());
Console.WriteLine(lägenhet.Fastighetsavgift());


            #endregion



            #region Fråga 7

            //int[] tal = { 9, 3, 7, 2, 1, 3, 4, 4, 2, 5, 74, 4, 2, 88 };

            //var evenNumbers = tal.Distinct().Where(x => x % 2 == 0).OrderByDescending(x => x);

            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}



            #endregion

            #region Fråga 8

//string[] cities = { "Stockholm", "Göteborg", "Malmö", "Köpenhamn", "London" };

//var countLetter = string.Join("", cities).Count();

//Console.WriteLine(countLetter);

            #endregion
        }
}
}
