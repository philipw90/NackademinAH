using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adressbook1.User;
using System.IO;
using System.Runtime.CompilerServices;

namespace Adressbook1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contacts> contact = new List<Contacts>();

        private void Form1_Load(object sender, EventArgs e)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Adress Book - Andre"))
            {
                Directory.CreateDirectory(path + "\\Address Book - Andre");
            }
            if (!File.Exists(path + "\\Address Book - Andre\\settings.xml"))
            {
                File.Create(path + "\\Address Book - Andre\\settings.xml");
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string saveInfo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                              "\\Address Book - Andre\\settings.txt";
            using (StreamWriter saveToFile = new StreamWriter(saveInfo))
            {


                foreach (var contacts in contact)               
                {
                    saveToFile.WriteLine(contacts.ToString());
                    saveToFile.Close();
                }

                
            }

        }

        private void lblZipCode_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxName.Text = contact[listView1.SelectedItems[0].Index].UserName;
                txtBoxStreet.Text = contact[listView1.SelectedItems[0].Index].UserStreet;
                txtBoxZipCode.Text = contact[listView1.SelectedItems[0].Index].UserZipCode;
                txtBoxCity.Text = contact[listView1.SelectedItems[0].Index].UserCity;
                txtBoxPhone.Text = contact[listView1.SelectedItems[0].Index].UserPhoneNr;
                txtBoxEmail.Text = contact[listView1.SelectedItems[0].Index].UserEmail;
            }
            catch {}


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                contact.RemoveAt(listView1.SelectedItems[0].Index);
            }
            catch { }
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            Contacts newUser = new Contacts();
            newUser.UserName = txtBoxName.Text;
            newUser.UserStreet = txtBoxStreet.Text;
            newUser.UserZipCode = txtBoxZipCode.Text;
            newUser.UserCity = txtBoxCity.Text;
            newUser.UserPhoneNr = txtBoxPhone.Text;
            newUser.UserEmail = txtBoxEmail.Text;
            contact.Add(newUser);

            listView1.Items.Add(newUser.UserName);
            txtBoxName.Text = "";
            txtBoxStreet.Text = "";
            txtBoxZipCode.Text = "";
            txtBoxCity.Text = "";
            txtBoxPhone.Text = "";
            txtBoxEmail.Text = "";




        }
    }

}
