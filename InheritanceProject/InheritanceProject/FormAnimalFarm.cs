using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public FormAnimalFarm()
        {
            InitializeComponent();
            animals = new List<Animal>();
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
            NumberOfAnimalsOnFarm();
        }

        private void buttonBuyChicken_Click(object sender, EventArgs e)
        {
            CreateNewChicken(textBoxNameChicken.Text, Int32.Parse(textBoxAgeChicken.Text));
            NumberOfAnimalsOnFarm();
            InfoAboutTheAnimals();
        }

        private void lblAnimalsOnFarm_Click(object sender, EventArgs e)
        {

        }

        public string NumberOfAnimalsOnFarm()
        {
           return lblAnimalsOnFarm.Text = animals.Count.ToString();
        }

        public void InfoAboutTheAnimals()
        {
            
            foreach (var Animals in animals)
            {
                
            }
        }

    }
}
