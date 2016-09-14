using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {

        Course Course = new Course();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                

                Course.name = txtCourseName.Text;
                Course.points = int.Parse(txtCoursePoints.Text);
                Course.startDate = dtpStartDate.Value;
                Course.endDate = dtpEndDate.Value;

                string startDateString = dtpStartDate.Value.ToString("yyyy-MM-dd");
                string endDateString = dtpEndDate.Value.ToString("yyyy-MM-dd");

                MessageBox.Show("Klassnamnet är: " + Course.name + ".\n Poängen är: " + Course.points +
                                ".\n Startdatum: " + startDateString + ". \n Slutdatum: " + endDateString +".");

            }
            catch
            {
                MessageBox.Show("Enter the right type of values please!");
            }

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Course.startDate = dtpStartDate.Value;
            Course.endDate = dtpEndDate.Value;
            MessageBox.Show("Kursen pågår i " + Course.CalculateCourseLength() + " dagar.");
        }

        private void btnCalculatePoints_Click(object sender, EventArgs e)
        {
            Course.startDate = dtpStartDate.Value;
            Course.endDate = dtpEndDate.Value;

            Course.points = int.Parse(txtCoursePoints.Text);
            MessageBox.Show("Antal poäng per dag: " + Course.PointsPerCourseDay());
        }
    }
}
