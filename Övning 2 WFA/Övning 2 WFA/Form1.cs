using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2_WFA
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Constant userInfo = new Constant();
            Welcome Messeage = new Welcome();
            Messeage.WelcomeMessage = textBox1.Text;

            if (userInfo.RealEmail == textBox1.Text && userInfo.RealPassword == textBox2.Text)
            {
                MessageBox.Show("Access Granted");
                Messeage.Show();
                Hide();
            }
            else if (userInfo.RealEmail != textBox1.Text && userInfo.RealPassword == textBox2.Text)
            {
                MessageBox.Show("Wrong Username");
            }
            else if (userInfo.RealEmail == textBox1.Text && userInfo.RealPassword != textBox2.Text)
            {
                MessageBox.Show("Wrong Password");
            }
            else
            {
                MessageBox.Show("Access Deneid");
            }
        }
    }
}
