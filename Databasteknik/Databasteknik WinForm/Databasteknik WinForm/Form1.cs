using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Databasteknik_WinForm.Controllers;
using Databasteknik_WinForm.Models;

namespace Databasteknik_WinForm
{
    public partial class Form1 : Form
    {
        private readonly ClassController _classController;
        private readonly ElevController _elevController;
        public Form1()
        {
            _classController = new ClassController();
            _elevController = new ElevController();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxClass.DataSource = _classController.GetAllClasses();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Elev elev = new Elev
            {
                Personnummer = txtBoxPersonnummer.Text,
                Fornamn = txtBoxFirstName.Text,
                Efternamn = txtBoxLastName.Text,
                Epost = txtBoxEmail.Text,
                Klasskod = ((Klass) comboBoxClass.SelectedItem).Kod,
                Telefon = txtBoxTelefon.Text,
                Ort = txtBoxCity.Text
            };
            if (_elevController.CreateNewElev(elev))
            {
                MessageBox.Show("Eleven har lagts till!");
            }
            else
            {
                MessageBox.Show("Das fail"); 
            }
          
        }
    }
}
