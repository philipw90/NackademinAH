using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Teachers newTeachers = new Teachers();
            string[] myArray2 = newTeachers.ResponsibleTeacher();

            string courses = "";
            for (int i = 0; i < myArray2.Length; i++)
            {
                courses += myArray2[i] +"\n";
                
            }
            MessageBox.Show(txtBoxName.Text + " är ansvarig för följande kurser:\n"+ "\n" + courses);



            //MessageBox.Show(myArray2[0]+ "\n" +myArray2[1]+ "\n" +myArray2[2]);

        }
    }
}
