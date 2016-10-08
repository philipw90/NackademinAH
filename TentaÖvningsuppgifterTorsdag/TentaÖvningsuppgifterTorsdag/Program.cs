using System;
using System.Linq;
using System.Text;

namespace TentaÖvningsuppgifterTorsdag
{
    public class Program
    {
        

        private static void Main(string[] args)
        {
            //Övning 1 sortera en sträng av nummer:
            //Console.WriteLine(SortStringChars())
            //Console.WriteLine(SortString());

           // Console.WriteLine(NumbersOfWords());

        }

        //Övning 1 sortera en sträng av nummer:

        //Alt 1
        //public static string SortStringChars()
        //{
        //    var numbers = "231596874";
        //    char[] sortedNumbers = numbers.ToCharArray();
        //    Array.Sort(sortedNumbers);
        //    return new string(sortedNumbers);
        //}

        //Alt2
        //public static string SortString()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    var strängen1 = "231596874";

        //    int[] nuInts = new int[strängen1.Length];

        //    for (int i = 0; i < strängen1.Length; i++)
        //    {
        //        nuInts[i] = int.Parse(strängen1[i].ToString());
        //    }

        //    var sortedNumber = 0;
        //    foreach (var number in nuInts)
        //    {
        //        if (number > sortedNumber)
        //        {
        //            stringBuilder.Append(number);
        //        }
        //    }
        //    return stringBuilder.ToString();
        //}

        //public static int NumbersOfWords()
        //{
        //    string sträng = "Detta är min text som jag matar in";

            
        //   var returen = sträng.Count(x => x == ' ');
        //    var returenOrd = sträng.Count(x => x == ' ');
        //    var numbersOfWords = sträng.Split().Count();

        //    // int countOfA = sträng.Split('a').Length - 1;
        //    //int count = sträng.Split(' ').Length;

        //    var count = 0;
        //    foreach (var words in sträng.Split(' '))
        //    {
        //        if (words.Contains("a"))
        //        {
        //            count++;
        //        }
        //    }

        //    return count; //+ " Och nummbers a " + countOfA;
        }
    }
}
