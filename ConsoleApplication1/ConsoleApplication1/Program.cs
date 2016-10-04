using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //string myString = "Detta är min sträng";
            //var i = myString.Split(' ').Length;
            //Console.WriteLine(i);

           // Uppgift 2

            //string myString = "Detta är min andra sträng";

            //string s = new CultureInfo.TextInfo.ToTitleCase(myString);

            //Console.WriteLine(s);



            //Uppgift 3


            string myString = "Detta är min tredje sträng";
            var x = CheckIfContainsLetter(myString);

            Console.WriteLine(x);
        }

        static public bool CheckIfContainsLetter(this string myString)
        {
            if (myString.Contains("t"))
            {
                return true;
            }
            return false;
        }

        // Vid extentionmetoder så måste metoden vara static och this måste vara inparameter.
    }
    }

}

