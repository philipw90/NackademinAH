using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetGrades_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(textBoxName.Text,textBoxLastName.Text,textBoxPesNumber.Text,textBoxPhone.Text,textBoxEmail.Text);
            if (newStudent.dialogResult == DialogResult.Yes)
            {
                string[,] grades = newStudent.GetGrades();

                for (int i = 0; i < grades.GetLength(0); i++)
                {
                    listBoxCourses.Items.Add(grades[i, 0] + ", " + grades[i, 1]);

                }
            }

        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text ="";
                    
                }

            }

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(textBoxName.Text, textBoxLastName.Text, textBoxPesNumber.Text, textBoxPhone.Text, textBoxEmail.Text);
            StudentInfo newStudentInfo = new StudentInfo(newStudent);
            newStudentInfo.Show();
        }
    }
}
