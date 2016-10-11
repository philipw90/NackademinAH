using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TentaInstuderingsuppgifterigen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Övning 1

            // 1. Skapa en klass som beskriver en Hund. Hunden har ett namn, en färg och en ägare.
            // Ägaren skall komma från en klass Hundägare som ärver från klassen Person(Namn,
            // adress, telefon).En hundägare har även ett Ägarnummer.

            //Övning 2

            // 2.Deklarera en array av klassen Hund samt lägg in 2 hundar i arrayen.

            //Dog[] dogs = new Dog[2];
            //Dog dog1 = new Dog
            //{
            //    Name = "Berra",
            //    Color = "Black",
            //    Dogowner = new Dogowner
            //    {
            //        Namn = "Erik",
            //        Adress = "Gatan",
            //        Phone = "070",
            //        OwnerId = 2
            //    }

            //};

            //Dog dog2 = new Dog
            //{
            //    Name = "Berra",
            //    Color = "Black",
            //    Dogowner = new Dogowner
            //    {
            //        Namn = "Göran",
            //        Adress = "Vägen",
            //        Phone = "070",
            //        OwnerId = 1
            //    }
            //};

            //dogs[0] = dog1;
            //dogs[1] = dog2;

            //// Övning 3
            //Du har talen 265 - 290 Dra roten ur alla jämna tal och addera rötterna. Skriv ut summan

            //double squareRootSum =0;


            //for (int i = 265; i < 291; i++)
            //{
            //    if (i % 2 ==0)
            //    {
            //        squareRootSum += Math.Sqrt(i);
            //    }
            //}
            //Console.WriteLine(squareRootSum);

            //Övning 4
            //Sortera strängen "231596874" till strängen "123456789" med en egen sorteringsfunktion

            // string numbers = "231596874";

            //string sortedString = "";

            //var sorted = numbers.OrderBy(x => x);

            //foreach (var number in sorted)
            //{
            //    sortedString += number;
            //}

            //char[] sortedString = numbers.ToArray();
            //Array.Sort(sortedString);
            //new string(sortedString);

            //Console.WriteLine(sortedString);

            // Övning 5

            //Summera de udda talen i följande array:

            // int[] array = { 3, 2, 4, 1, 7, 8, 11, };

            // int evenNumbers = 0;

            // foreach (var numbers in array)
            // {
            //     if (numbers %2 !=0)
            //     {
            //         evenNumbers += numbers;
            //     }
            // }

            // Console.WriteLine(evenNumbers);

            //Console.WriteLine(array.Where(x => x % 2 != 0).Sum());


            // Övning 6

            //Sortera alla namn i strängen i bokstavsordning.Visa kod för detta:

            //StringBuilder stringBuilder = new StringBuilder();

            //string namn = "Kurt,Oskar,Sven,Nils";

            //var nameSplit = namn.Split(',');

            ////nameSplit.OrderBy(x=>x).ToList().ForEach(Console.WriteLine);

            //var sorted = nameSplit.OrderBy(x => x).ToList();

            //foreach (var names in sorted)
            //{

            //    stringBuilder.Append(names + ",");
            //}

            //Console.WriteLine(stringBuilder);

            // Övning 7
            //Skapa en metod Plusminus som tar emot två tal samt returnerar både summan och skillnaden av talen.

            //    int diffrence;          

            //    Console.WriteLine(PlusMinus(10, 13, out diffrence) + "    " + diffrence);


            //}

            //public static int PlusMinus(int value1, int value2, out int diffrence)
            //{


            //    var sum = value1 + value2;

            //    diffrence = Math.Abs(value1 - value2);

            //    return sum;

            //    //return "Summan är: " + sum + " Och skillnaden är: " + diffrence;

            // Övning 8

            //Ta bort alla dubletter i arrayen {11,11,12,12,13,13,14,15,16} och skapa en ny array utan dubletter

            //int[] myArray =  new int[] { 11, 11, 12, 12, 13, 13, 14, 15, 16 };

            //var newArray = myArray.Distinct().ToArray();

            //foreach (var item in newArray)
            //{
            //    Console.WriteLine(item);
            //}

            // Övning 9

            // Hur många tal mellan 1-1000 är jämt delbara med 17? Ange kod + antal 

            //int numbers = 0;

            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 17 ==0)
            //    {
            //        numbers++;
            //    }
            //}
            //Console.WriteLine(numbers);

            //Övning 10

            // Skriv en default och en överlagrad konstruktor till klassen Bil som sätter värden på
            // alla properties i klassen. En Bil har ett regnr en årsmodell och ett märke. Det skall
            // även gå att skapa en instans utan att sätta properties direkt.


            // Se bil class

            //Övning 11

            //. Gör ett program där användaren får mata in en mening t ex ”Detta är min text som
            // jag matar in”. Programmet skall räkna ut hur många ord meningen består av och
            // meddela användaren om detta.Ta också fram hur många ord som innehåller bokstaven a. 


            //    Console.WriteLine("Mata in en sträng");
            //    Console.WriteLine(CountWordsAndLetters(Console.ReadLine()));

            //}


            //public static string CountWordsAndLetters(string input)
            //{
            //    var myString = input;

            //    var word = myString.Split(' ').Count();

            //    var letters = myString.Count(x => x == 'a');

            //    return " Din stäng innehåller " + word + " ord och " + letters + " antal a ";

            // Övning 12

            // Skapa en metod som du döper till HittaSträngar. Metoden skall ta som inparameter en array med strängar.
            // Metoden skall returnera både den längsta strängen och denkortaste strängen som finns i arrayen. 


            //    string[] MrArray = new[] { "Detta är en sträng loooonnnggg som fan", "det är en array", " detta ","dan", "hbiatchaaaasie", "i" };

            //    Console.WriteLine(HittaSträngar(MrArray));
            //}


            //public static string HittaSträngar(string[] myArray)
            //{
            //    return "Den längsta strängen är: " + myArray.OrderBy(x => x.Length).Last() + " Och den kortaste är:  " + myArray.OrderBy(x => x.Length).First();

            //}

            // Övning 13

            // Skapa en klass som heter Person. En person har ett namn och en adress och ett
            // telefonnummer.Skapa två klasser som ärver från Person, Kund och Instruktör.En Kund har
            // även egenskapen abonnemang och en Instruktör har en lön. Alla personer måste ha en
            // metod som heter BokaTräningspass, men detta skall fungera olika i klasserna. Visa med kod hur detta görs. 


            // Övning 14 se class Person, Kund, Instruktör

            //Du har följande: string: string s= "Flygande beckasiner söka whila på mjuka tufvor"; . Skapa
            //en metod SortString som returnerar en ny sträng där alla orden kommer sorterade i bokstavsordning.


            //    Console.WriteLine(SortString());
            //}

            //public static string SortString()
            //{
            //   string s= "Flygande beckasiner söka whila på mjuka tufvor";

            //    StringBuilder stringBuilder = new StringBuilder();

            //    var splitedString = s.Split(' ');

            //    var sorted = splitedString.OrderBy(x => x);

            //    foreach (var sortwords in sorted)
            //    {
            //        stringBuilder.Append(sortwords + " ");
            //    }

            //    return stringBuilder.ToString();

            //}

            // Övning 15

            // Skapa en ny lista utifrån denna sträng array. Där skall alla namnen vara sorterade på
            // efternamn i bokstavsordning.Detta skall göra med LINQ eller lambda uttryck. 

            //string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Blom", "Lisa Lind" };

            //var sortedList = namnLista.OrderBy(x => x.ElementAt(x.IndexOf(' ') + 1)).ToList();

            //foreach (var names in sortedList)
            //{
            //    Console.WriteLine(names);
            //}

            // Övning 18
            // . Du har två metoder Start() och Beräkna(). Från Start() skall du anropa Beräkna() och skicka
            //med strängarna varde1 och varde2 som inparametrar.I Beräkna() kontrollerar du om varde1
            //och varde2 är tal.Om de är tal multiplicerar du talen och returnerar dem som en double.Om
            //de inte är tal returnerar du - 1.
//            Start();

//        }

//        public static void Start()
//        {
//            Console.WriteLine(Beräkna("10", "25"));

//        }

//        public static double Beräkna(string input1,string input2)
//        {
//            try
//            {
//                var value1 = double.Parse(input1);
//                var value2 = double.Parse(input2);

//                var sum = value1*value2;

//                return sum;
//            }
//            catch (Exception)
//            {
//                return -1;
//            }
//        }

//    }
    
//}



