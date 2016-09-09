using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_6_WFA
{
    public partial class frmResize : Form
    {
        public frmResize()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmResize_Resize(object sender, EventArgs e)
        {
            
         textBox1.Height = this.Height - 80;
         textBox1.Width = this.Width - 80;
         textBox1.Left = Left - 80;

        }

        private void textBox1_Resize(object sender, EventArgs e)
        {

        }
    }
}
