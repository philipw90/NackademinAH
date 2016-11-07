using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTenta
{
    public static class ExtensionMetoder
    {
//	Skapa en extensionmetod till datatypen string. Den ska returnera strängen i bokstavsordning, dvs strängen ”koriander” ska bli ”adeiknorr”. Använd inte LINQ.

        public static string AplpahbeticOrder(this string input) //Fråga 3
        {
            var myString = input;
            char[] myChar = myString.ToCharArray();
            Array.Sort(myChar);

            return new string(myChar);
        }

    }
}
