using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tenta.Övning_carls_uppgift;

namespace Tenta
{
    class Program
    {
        private static void Main(string[] args)
        {
            //    int[] myArray = new int[100];
            //    int even = 0;
            //    int odd = 0;

            //    for (int i = 0; i < myArray.Length; i++)
            //    {
            //        myArray[i] = i;

            //        if (i%2 == 0)
            //        {
            //            even += i;
            //            odd ++;
            //        } 
            //    }
            //    Console.WriteLine(even/odd);



            ////    int odd = 0, even = 0;

            ////    double average1 = myArray.Average();

            ////    for (int i = 0; i < myArray.Length; i++)
            ////    {
            ////        if (i % 2 == 0)
            ////            even++;
            ////        else
            ////            odd++;
            ////    }

            ////    Console.WriteLine(average1);


            ////    //foreach (int i in myArray)
            ////    //{
            ////    //    if (i%2 == 0)
            ////    //        even++;
            ////    //    else
            ////    //        odd++;
            ////    //}

            ////    Console.WriteLine("Found {0} Odd Numbers, and {1} Even Numbers.", odd, even);
            ////    Console.WriteLine();



            //Övning 7-9

            //Fest fest = new Fest();
            //Deltagare deltagare = new Deltagare();

            //fest.Värd = deltagare;
            // var värd = new Deltagare
            // {
            //     Förnamn = "Kalle",
            //     Efternamn = "Adma",
            //     Ålder = 25,

            // };
            // var deltagare1 = new Deltagare
            // {
            //     Förnamn = "Andre",
            //     Efternamn = "Holmlund",
            //     Ålder = 25
            // };
            // var deltagare2 = new Deltagare
            // {
            //     Förnamn = "Erik",
            //     Efternamn = "Holmlund",
            //     Ålder = 25
            // };


            // //Fest fest = new Fest("Tentapub","ÖÖÖL",DateTime.Now, DateTime.Now, 900, "Nacka", värd);
            // //fest.Deltagare = new List<Deltagare>();
            //// fest.NyDeltagare(deltagare1);
            // //fest.NyDeltagare(deltagare2);

            // //fest.AntalDeltage();

            // Halloweenfest halloweenfest = new Halloweenfest("Tentapub", "ÖÖÖL", DateTime.Now, DateTime.Now, 900, "Nacka", värd);
            // halloweenfest.NyDeltagare(deltagare1);
            // halloweenfest.NyDeltagare(deltagare2);
            // halloweenfest.LokalKostnad = 200;
            // halloweenfest.Inträde();

            // Förfest förfest = new Förfest("Tentapub", "ÖÖÖL", DateTime.Now, DateTime.Now, 900, "Nacka", värd);
            // förfest.NyDeltagare(deltagare1);
            // förfest.NyDeltagare(deltagare2);
            // förfest.LokalKostnad = 300;
            // förfest.Inträde();

            //IUserRepository userRepository = new UserRepository();
            //User newUser = userRepository.CreateUser("Andre", "1234", "Email@Email.com");
            //userRepository.DeleteUser(newUser.Email);


            //Övning
            //    Start();


            //public static void Start()
            //{
            //    var varde1 = "50";
            //    var varde2 = "60";

            //    var info = Beräkna(varde1, varde2);

            //    Console.WriteLine(info);
            //}

            //public static double Beräkna(string varde1, string varde2)
            //{

            //    try
            //    {
            //        var input1 = double.Parse(varde1);
            //        var input2 = double.Parse(varde2);
            //        return input1*input2;
            //    }
            //    catch (Exception)
            //    {
            //        return -1;
            //    }     
            //}

            StartPage startPage = new StartPage
            {
                Rubrik = "Rubrik",
                Ingress = "Fet jävla ingress",
                GoogleAnalytics = " Google kod"
                
            };
            

            var sidId = startPage.SidId;

            Console.WriteLine(startPage.Rubrik);
            Console.WriteLine(startPage.Ingress);
            Console.WriteLine(startPage.GoogleAnalytics);
            Console.WriteLine(sidId);
            Console.WriteLine();
            Console.WriteLine();

            ArticlePage articlePage = new ArticlePage
            {
                Text = "Ny Text",
                Ingress = "Ny Ingress",
                Rubrik = "Ny Rubrik"  
            };

            
            var sidId2 = articlePage.SidId;

            Console.WriteLine(articlePage.Rubrik);
            Console.WriteLine(articlePage.Ingress);
            Console.WriteLine(articlePage.Text);
            Console.WriteLine(sidId2);
        }

    }

}
