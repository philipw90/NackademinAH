using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Övning_1_Filhantering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;

            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Projects\\FromVS.txt");
            file.WriteLine(text);

            file.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"C:\projects\FromVS.txt");


            textBox2.Text = text;
            
            

            
        }
    }
}
