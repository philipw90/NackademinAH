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
using Adressbook1.User;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;
using Adressbook1.Constants;

namespace Adressbook1
{
    public partial class Form1 : Form
    {
        
        
        Database database = new Database();
        Search search = new Search();
        List<Contact> resultUser = new List<Contact>();
        List<Contact> resultStreet = new List<Contact>();
        List<Contact> _book;
   


        public Form1()
        {
            InitializeComponent();

            database = new Database();
            _book = database.GetFile();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.UserImput(txtBoxName.Text,txtBoxStreet.Text,txtBoxZipCode.Text,txtBoxCity.Text,txtBoxPhone.Text,txtBoxEmail.Text);

            Database save = new Database();
            save.SaveToFile(contact);
            ClearTextbox();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
            var contactId = HttpRuntime.Cache["CONTACT_ID"] as string;
            Database.DeleteContact(contactId);
            listBox1.DataSource = new List<Contact>();
            ClearTextbox();
            


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtBoxSearch.Text.ToLower();
            List<Contact> searchResult = new List<Contact>();

            foreach (var contact in _book)
            {
                if (contact.UserName.Contains(searchName))
                {
                    searchResult.Add(contact);
                }
                if (contact.UserStreet.Contains(searchName))
                {
                    searchResult.Add(contact);
                }
            }

            listBox1.DataSource = searchResult;
            listBox1.DisplayMember = "UserName";


        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var contact = (Contact)listBox1.SelectedItem;

            txtBoxName.Text = contact.UserName;
            txtBoxStreet.Text = contact.UserStreet;
            txtBoxZipCode.Text = contact.UserZipCode;
            txtBoxCity.Text = contact.UserCity;
            txtBoxPhone.Text = contact.UserPhoneNr;
            txtBoxEmail.Text = contact.UserEmail;
            //id = contact.Id;

            HttpRuntime.Cache.Insert("CONTACT_ID", contact.Id);

        }
        public void ClearTextbox()
        {
            txtBoxCity.Clear();
            txtBoxEmail.Clear();
            txtBoxName.Clear();
            txtBoxPhone.Clear();
            txtBoxStreet.Clear();
            txtBoxZipCode.Clear();
            listBox1.ClearSelected();
            txtBoxSearch.Clear();
        }
    }

}
