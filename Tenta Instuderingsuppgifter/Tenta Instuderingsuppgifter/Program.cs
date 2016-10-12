using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_Instuderingsuppgifter
{
    class Program
    {
        //Övning 1

        //  Skapa en klass som beskriver en Hund.Hunden har ett namn, en färg och en ägare.
        //  Ägaren skall komma från en klass Hundägare som ärver från klassen Person( Namn,
        //  adress, telefon). En hundägare har även ett Ägarnummer.

        //  Övning 2

        //  Deklarera en array av klassen Hund samt lägg in 2 hundar i arrayen.

        private static void Main(string[] args)
        {
            // Övning 1-2
            //Dog[] myDogArray = new Dog[2];

            //DogOwner one = new DogOwner() { Name = "Andre", Adress = "Falköpingsvägen 17", OwnerId = "1" };
            //DogOwner two = new DogOwner() { Name = "Andre", Adress = "Falköpingsvägen 17", OwnerId = "2" };

            //Dog dog1 = new Dog() { Name = "Bengt", Color = "Svart", DogOwner = one };
            //Dog dog2 = new Dog() { Color = "Grön", Name = "Fiddo", DogOwner = two };

            //myDogArray[0] = dog1;
            //myDogArray[1] = dog2;

            //Console.WriteLine(myDogArray[0]);
            //Console.WriteLine(myDogArray[1]);

            //Övning 3

            // Du har talen 265-290 Dra roten ur alla jämna tal och addera rötterna. Skriv ut summan

            //int[] myEvenNumberArray = new int[26];

            //for (int i = 0; i < myEvenNumberArray.Length; i++)
            //{
            //    myEvenNumberArray[i] = 265 + i;
            //}

            //double squareRoot = 0;

            //foreach (var numberInArray in myEvenNumberArray)
            //{
            //    if (numberInArray % 2 == 0)
            //    {
            //        squareRoot += Math.Sqrt(numberInArray);
            //    }
            //}

            //Console.WriteLine(squareRoot);

            //var linqRoot = myEvenNumberArray.Where(x => x % 2 == 0).Sum(c => Math.Sqrt(c));

            //Console.WriteLine(linqRoot);

            // Övning 4

            //Sortera strängen "231596874" till strängen "123456789" med en egen sorteringsfunktion


            //string myString = "231596874";

            //myString.OrderBy(x => x).ToList().ForEach(Console.Write);


            //char[] sortedString = myString.ToArray();
            //Array.Sort(sortedString);
            //new string(sortedString);

            //Console.WriteLine(sortedString);

            // Övning 5

            //Summera de udda talen i följande array:

            //int[] oddArray= { 3, 2, 4, 1, 7, 8, 11, };

            //var oddnumbers = oddArray.Where(x => x%2 != 0).ToArray().Sum();

            //Console.WriteLine(oddnumbers);

            // Övning 6

            //   Sortera alla namn i strängen i bokstavsordning.Visa kod för detta:

            //string namn = "Kurt,Oskar,Sven,Nils";

            //var nameSplit = namn.Split(',');

            //nameSplit.OrderBy(x => x).ToList().ForEach(Console.WriteLine);

            //Övning 7

            //  Skapa en metod Plusminus som tar emot två tal samt returnerar både summan och
            //  skillnaden av talen.

            //Console.WriteLine(Plusminus(10, 2));


            //public static string Plusminus(int value1, int value2)
            //{
            //    var sum = value1 + value2;

            //    var diffrence = Math.Abs(value1 - value2);

            //    return "Summan av de två talen är: " + sum + " och Skillnaden mellan de två talen är: " + diffrence;

            //

            // Övning 8

            //Ta bort alla dubletter i arrayen { 11,11,12,12,13,13,14,15,16}
            //och skapa en ny array utan dubletter

            //int[]numbers = new int[] {11, 11, 12, 12, 13, 13, 14, 15, 16};

            //numbers.Distinct().ToArray().ToList().ForEach(Console.WriteLine);

            //Övning 9

            //Hur många tal mellan 1-1000 är jämt delbara med 17? Ange kod + antal

            //    int numbers = 0;

            //    for (int i = 1; i < 1001; i++)
            //    {
            //        if (i % 17 == 0)
            //        {
            //            numbers++;
            //        }
            //    }
            //    Console.WriteLine(numbers);
            //}

            //  Skriv en default och en överlagrad konstruktor till klassen Bil som sätter värden på
            //  alla properties i klassen. En Bil har ett regnr en årsmodell och ett märke. Det skall
            //  även gå att skapa en instans utan att sätta properties direkt.

            // Uppgift 11

            // Gör ett program där användaren får mata in en mening t ex ”Detta är min text som
            // jag matar in”. Programmet skall räkna ut hur många ord meningen består av och
            //  meddela användaren om detta.Ta också fram hur många ord som innehåller bokstaven a.

            //    Console.WriteLine("Mata in en sträng: ");

            //    Console.WriteLine(CountWordsAndWords(Console.ReadLine()));

            //}

            //Uppgift11
            //public static string CountWordsAndWords(string input)
            //{
            //    var myString = input; 

            //    var myStringWords = myString.Trim().Split(' ').Count();

            //    var myStringCountWords = myString.Count(x => x == 'a');

            //    return myStringWords + " Antal ord i din sträng och " + myStringCountWords +  " antal a i din sträng ";

            //}

            //Uppgift 12 
            //  Skapa en metod som du döper till HittaSträngar. Metoden skall ta som inparameter
            //  en array med strängar.Metoden skall returnera både den längsta strängen och den kortaste strängen som finns i arrayen.

            //string[] myStrings = new string[] { "Den första stängen", "Denna andra strängen som är den längsta", "tjobba" };
            //Console.WriteLine(HittaSträngar(myStrings));


            //public static string HittaSträngar(string[] myArray)
            //{
            // var shortArray = myArray.OrderBy(x => x.Length).ToString();

            //var longArray = myArray.OrderBy(x => x.Last());
            //var shortArray = myArray.OrderBy(x => x.First());

            //return longArray;
            //return "Den längsta strängen är: "  + myArray.OrderBy(x => x.Length).Last() + "   Och den kortaste är:   " + myArray.OrderBy(x => x.Length).First();
            //}

            //Uppgift 13


            //Uppgift 14


            //  Du har följande: string: string s= "Flygande beckasiner söka whila på mjuka tufvor"; . Skapa
            //  en metod SortString som returnerar en ny sträng där alla orden kommer sorterade i bokstavsordning.

            //    Console.WriteLine(SortString());

            //public static string SortString()
            //{
            //    string s = "Flygande beckasiner söka whila på mjuka tufvor";

            //    StringBuilder stringBuilder = new StringBuilder();

            //    var splitString = s.Split(' ');

            //    var orderdString = splitString.OrderBy(x => x).ToList();

            //    foreach (var item in orderdString)
            //    {
            //        stringBuilder.Append(item + ",");
            //    }

            //    return stringBuilder.ToString();

            //}

            // Uppgift 15

            //  Skapa en ny lista utifrån denna sträng array. Där skall alla namnen vara sorterade på
            //  efternamn i bokstavsordning . Detta skall göra med LINQ eller lambda uttryck

            //    foreach (var item in SortedList())
            //    {
            //        Console.WriteLine(item);
            //    }

            //}

            //public static List<string> SortedList()
            //{
            //    string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Öblom", "Lisa Lind" };

            //    var sortedName = namnLista.OrderBy(x => x.ElementAt(x.IndexOf(' ') +1)).ToList();


            //    return sortedName;
            //}

            //Övning 16 se pizza projektet
            //Övning 17 se pizza projektet

            //Övning 18
            // Du har två metoder Start() och Beräkna().Från Start() skall du anropa Beräkna() och skicka
            // med strängarna varde1 och varde2 som inparametrar.I Beräkna() kontrollerar du om varde1
            // och varde2 är tal.Om de är tal multiplicerar du talen och returnerar dem som en double.Om de inte är tal returnerar du - 1.
            // Console.WriteLine(Start());
            //}

            //public static double Start()
            //{
            //  return Beräkna("2", "a");
            //}

            //public static double Beräkna(string varde1, string varde2)
            //{

            //    try
            //    {
            //        var input1 = double.Parse(varde1);
            //        var input2 = double.Parse(varde2);

            //        var sum = input1*input2;
            //        return sum;
            //    }
            //    catch (Exception)
            //    {
            //        return -1;
            //    }

            //List<int> integers = new List<int>() { 1978, 1959, 1960, 1958, 1962, 1980, 1945, 1985, 1954, 1968 };

            //var a = integers.Where(x => DateTime.Now.Year - x >= 50 && DateTime.Now.Year - x <= 60).OrderBy(x => x).First();

            //Console.WriteLine(a);


            //    LINQ - frågor

            // Sortera efter bokstavsordning
            // Räkna antal ”a”
            // Räkna antal tecken
            // Räkna antal ord
            // Räkna antal versaler
            // Sortera efter bokstavsordning ”aaaaBdE….”
            // Skriv ut alla namn i en sträng
            // Spegelvänd strängen


            //string[] names = { "maTilda", "BEa", "iSa" };
            
            //var sortedByAlpha = names.OrderBy(x => x);

            //var countLetterA = string.Join("", names).Count(x => x == 'a');

            //var countLetter = string.Join("", names).Count();

            //var countWords = names.Count();

            //var countCapitalLetters = string.Join(" ",names).Count(x => char.IsUpper(x));

            //var sortStringByAlpha = string.Join("", names).OrderBy(x => x.ToString()).ToArray();

            //var arraytoString = string.Join(" ", names);

            //var reverseStringVer2 = string.Join(" ", names).Reverse().ToArray();

            //Console.WriteLine(reverseStringVer2);








        }

    }
}

