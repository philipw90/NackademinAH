using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Databasteknik10.Controllers;
using Databasteknik10.Models;

namespace Databasteknik10
{
    public partial class Form1 : Form
    {
        private readonly CategoryController _categoryController;
        public Form1()
        {
            _categoryController = new CategoryController();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           List<ValidationResult> result = _categoryController.Create(new Category {Name = textBox2.Text});

            if (result.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result));
            }

        }
    }
}
