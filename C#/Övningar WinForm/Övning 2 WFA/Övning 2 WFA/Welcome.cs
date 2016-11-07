using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2_WFA
{
    public partial class Welcome : Form
    {
        public string WelcomeMessage { get; set; }
        
        public Welcome()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            lblWelcome.Text = WelcomeMessage;
            lblWelcome.Text = @"Welcome" + Text;

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
