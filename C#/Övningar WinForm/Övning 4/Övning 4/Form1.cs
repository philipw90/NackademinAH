using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime sdt = dtpstart.Value.Date;
            DateTime edt = dtpStop.Value.Date;

            TimeSpan ts = edt - sdt;



            textBox3Days.Text = (edt - sdt).TotalDays.ToString()+ " Days";
            textBox1Month.Text = (edt.Month - sdt.Month).ToString()+ " Month";
            textBox2Year.Text = (edt.Year - sdt.Year).ToString() +" Years";
            textBox1Hours.Text = (edt - sdt).TotalHours.ToString() + " Hours";

            //int days = ts.Days;
            //int months = 0;
            //int restDays = 0;
            //int years = 0;
            //int restMonth = 0;

            //if (days < 30)
            //{
            // textBox3Days.Text = days.ToString() + " Days";   
            //}
            //else if (days >= 30 && days < 365)
            //{
            //    months = days/30;

            //    textBox1Month.Text = months.ToString() + "Months";
            //    restDays = days - (months*30);
            //    textBox3Days.Text = restDays.ToString() + "Days";

            //}
            //else if (days >= 365)
            //{
            //    years = days/365;
            //    restMonth = (days - (years*365))/30;
            //    restDays = days - (restMonth*30) - (years * 365);

            //    textBox2Year.Text = years.ToString() + "Years";
            //    textBox1Month.Text = restMonth.ToString() + "Months";
            //    textBox3Days.Text = restDays.ToString() + "Days";
            //}


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


        }
    }


    }
