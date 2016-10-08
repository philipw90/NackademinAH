using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_ÖvningsuppgifterWinForm
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            uppgift8();
        }

        public void Uppgift1() //
        {
            string[] _cars = { "Volvo", "BMW", "Audi", "Skoda", "Toyota", "Ford", "Mercedes", "Seat", "Honda", "Volkswagen", "Opel", "Mazda", "Suzuki" };

            var searchText = textBox1.Text;

            // Uppgift 1a
            //var car = _cars.Where(x => searchText.Contains(x));

            //foreach (var items in car)
            //{
            //    MessageBox.Show(items);
            //}

            //Uppgift 1b
            // var car = _cars.Where(x => x.ToLower().StartsWith(searchText.ToLower()));

            //Uppgift 1c

            // var car = _cars.Where(x => x.ToLower().Contains(searchText.ToLower()));

            //Uppgift 1d Ta fram alla bilar som börjar på ”M” eller som slutar på ”i

            //var car = _cars.Where(x => x.StartsWith("M") || x.EndsWith("i"));

            //foreach (var items in car)
            //{
            //    MessageBox.Show(items);
            //}

        }

        public void Uppgift2()
        {
            //string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth",
            //                "Metallica", "Pearl Jam", "Oasis", "Abba", "Blur", "Eurythmics", "Genesis",
            //                "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "The Offspring",
            //                "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Deep Purple","U2"};

            //Uppgift 2a

            //string longestband = bands.OrderByDescending(x => x.Length).First();

            //Uppgift 2b
            //string longestband = bands.OrderByDescending(x => x.Length).Last();

            //Uppgift 2c  Ta fram en siffra på hur många band som börjar på bokstaven ”M”

            //var longestband = bands.Count(x => x.StartsWith("M")).ToString();

            //Uppgift 2d Ta ut en lista på alla band sorterad i bokstavsordning. Visa bara band som har ett bandnamn som är längre än 6 bokstäver

            //var orderList = bands.Where(x => x.Trim().Length > 6).OrderBy(x => x);

            //foreach (var items in orderList)
            //{
            //    MessageBox.Show(items);
            //}

            //Uppgift 2e e. Skapa en lista som sorteras på längden på banden namn. Det band med kortast namn skall hamna först i listan och det med längst namn skall hamna sist. 

            //var orderList = bands.OrderBy(x => x.Length);

            //foreach (var items in orderList)
            //{
            //    MessageBox.Show(items);
            //}


            //MessageBox.Show();



        }

        public void Uppgift3()
        {
            List<int> integers = new List<int>() { 54, 23, 76, 123, 93, 7, 3489, 88 };

            //Uppgift 3a Ta fram medelvärdet av alla tal utan att loopa igenom listan. 

            //var numbers = integers.Average().ToString();

            //Uppgift 3b Ta fram det största av alla tal utan att loopa igenom listan. 

            //var numbers = integers.Max().ToString();

            //Uppgift 3c Ta fram det minsta av alla tal utan att loopa igenom listan

            //var numbers = integers.Min().ToString();

            //Uppgift 3d Beräkna summan av alla tal

            //var numbers = integers.Sum().ToString();

            // Uppgift 3e Ta fram alla jämna tal utan att loopa igenom listan.

            //integers.Where(x => x%2 == 0).ToList().ForEach(x=> MessageBox.Show(x.ToString()));

            // MessageBox.Show(numbers);

        }

        public void Uppgift4()
        {
            // Uppgift 1a Du skall nu skapa en ny lista. Skapa listan med talen 1-10 via kod 
            //Enumerable.Range(1, 10).ToList().ForEach(x => MessageBox.Show(x.ToString()));
        }

        public void Uppgift6()
        {
            //Uppgift 6 Sortera på efternamn utan att använda någon loop

            //string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Blom" };

            //var sortedList = namnLista.OrderBy(x => x).ToArray();

            //foreach (var item in sortedList)
            //{
            //    MessageBox.Show(item);
            //}
        }

        public void Uppgift7()
        {
            //Uppgift 7 Skapa en ny lista från denna array där alla värden ökats med 2 dvs nya listan blir 3,5,7,9 

            //int[] lista = { 1, 3, 5, 7 };

            //lista.ToList().ForEach(x=> MessageBox.Show(x.ToString()));


            //var newList = lista.Select(x=> x + 2);

            //foreach (var item in newList)
            //{
            //    MessageBox.Show(item.ToString());
            //}
        }

        public void uppgift8()
        {

           // Skapa en lista med alla vokaler ur meningen string fullText = "Flygande beckasiner söka whila på mjuka tufvor"

            //string sentence = "Flygande beckasiner söka whila på mjuka tufvor";

            //var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä' };

            //sentence.ToList().ForEach(x => vowels.Contains(x));

            //var listSentence = sentence.Where(x => x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u' || x == 'y' || x == 'å' || x == 'ä');


            //foreach (var vowels2 in listSentence)
            //{
            //    MessageBox.Show(vowels2.ToString());
            //}



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
