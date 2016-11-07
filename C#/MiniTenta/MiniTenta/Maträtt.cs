using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTenta
{
    //Fråga 4

    //4.	Skapa klasserna Order och Maträtt. Order ska ha egenskapen Maträtter och metoden TotalPris. 
    //Klassen Maträtt har en konstruktor med parametrarna Namn och Pris, koppla dessa till klassens egenskaper. 
    //Instansiera en order och lägg till två maträtter. Returnera totalpriset på hela ordern. 
    public class Maträtt
    {
        public string Namn { get; set; }
        public int Pris { get; set; }

        public Maträtt(string namn, int pris)
        {
            Namn = namn;
            Pris = pris;
            
        }
    }
}
