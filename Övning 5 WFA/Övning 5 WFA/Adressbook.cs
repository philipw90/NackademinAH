using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5_WFA
{
    public partial class Adressbook : Form
    {
        public Adressbook()
        {
            InitializeComponent();

            comboBox1.Items.Add("Gift");
            comboBox1.Items.Add("Ogift");
            comboBox1.Items.Add("Annat");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text))
            {
                MessageBox.Show(@"Du har missat namn");
                txtBoxFirstName.Focus();
            }         
            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                MessageBox.Show(@"Du har missat efternamn");
                txtBoxLastName.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtBoxPrNum.Text))
            {
                MessageBox.Show(@"Du har missat personnummer");
                txtBoxPrNum.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                MessageBox.Show(@"Du har missat mailadress");
                txtBoxEmail.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtBoxPhone.Text))
            {
                MessageBox.Show(@"Du har missat telefonnummer");
                txtBoxPhone.Focus();
            }
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show(@"Du har missat att välja civilstånd");
                comboBox1.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text) == false&& string.IsNullOrWhiteSpace(txtBoxLastName.Text) == false&& string.IsNullOrWhiteSpace(txtBoxPrNum.Text)== false
                &&string.IsNullOrWhiteSpace(txtBoxEmail.Text)== false&& string.IsNullOrWhiteSpace(txtBoxPhone.Text) == false&& string.IsNullOrWhiteSpace(comboBox1.Text)== false)
                MessageBox.Show(@"Alla fällt är i fyllda");
            }

            //if (missing == null)
            //{
            //    MessageBox.Show("Du har missat");
            //}
            //if (missing == "")
            //{
            //    MessageBox.Show("Du har missat ");
            //}

    }
}
