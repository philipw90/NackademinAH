using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceProject
{
    public partial class FormAnimalFarm : Form
    {
        private List<Animal> animals;
        private List<Animal> deadAnimals;

        public FormAnimalFarm()
        {
            this.deadAnimals = deadAnimals;
            InitializeComponent();
            animals = new List<Animal>();
            deadAnimals = new List<Animal>();
        }

        private void CreateNewChicken(string name, int age)
        {
            Chicken chick = new Chicken(name, age);
            animals.Add(chick);
        }

        private void FormAnimalFarm_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewCow(string name, int age)
        {
            Cow cow = new Cow(name, age);
            animals.Add(cow);
            
        }

        private void buttonBuyCow_Click(object sender, EventArgs e)
        {
            CreateNewCow(textBoxNameCow.Text,int.Parse(textBoxAgeCow.Text));
            Clear();
            NumberOfAnimalsOnFarm();
            InfoAboutTheAnimals();
            ShowAnimalInfo();
        }

        private void buttonBuyChicken_Click(object sender, EventArgs e)
        {
            CreateNewChicken(textBoxNameChicken.Text, Int32.Parse(textBoxAgeChicken.Text));
            Clear();
            NumberOfAnimalsOnFarm();
            InfoAboutTheAnimals();
            ShowAnimalInfo();
        }

        private void lblAnimalsOnFarm_Click(object sender, EventArgs e)
        {

        }

        public string NumberOfAnimalsOnFarm()
        {
           return lblAnimalsOnFarm.Text = " Animals on the farm " + animals.Count.ToString();
        }

        public void InfoAboutTheAnimals()
        {
            
            foreach (var Farm in animals)
            {

                    lblnfoOfAnimal.Text += Farm.Name + @" " + Farm.Age + @" ";
            }
        }

        public void Clear()
        {
            lblnfoOfAnimal.Text = "";
        }

        private void btnNextYear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poop");
            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].HaveBirthday();

                if (animals[i].alive == false)
                {
                    deadAnimals.Add(animals[i]);
                    animals.RemoveAt(i);
                }
            }
            Clear();
           // InfoAboutTheAnimals();
            ShowAnimalInfo();
        }

        private void lblDeadAnimals_Click(object sender, EventArgs e)
        {

            
        }

        public void ShowAnimalInfo()
        {
           //lblnfoOfAnimal.Text = "Number of animals: " + animals.Count.ToString();

            lblDeadAnimals.Text = "Dead animals: " + deadAnimals.Count.ToString();
            lblAnimalsAlive.Text = "Alive animals: " + animals.Count.ToString();

            foreach (var animal in animals)
            {
                lblnfoOfAnimal.Text += " \n" + animal.Name + " " + animal.Age;
            }
        }

    }
}
