using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Adressbook1.User;
using System.IO;
using System.Web;
using Adressbook1.Constants;

namespace Adressbook1
{
    public partial class Form1 : Form
    {       
        Database _database = new Database();
        List<Contact> _book;
        static string pathToTextFile = @"C:\Projects\Adressbook.txt";

        public Form1()
        {
            InitializeComponent();;
            _book = _database.GetFile();
            ValidateFields();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (HttpRuntime.Cache["CONTACT_ID"] != null)
            {
                var contactId = HttpRuntime.Cache["CONTACT_ID"] as string;

                var contact = _book.First(x => x.Id == contactId);

                contact.UserName = txtBoxName.Text;
                contact.UserStreet = txtBoxStreet.Text;
                contact.UserZipCode = txtBoxZipCode.Text;
                contact.UserCity = txtBoxCity.Text;
                contact.UserPhoneNr = txtBoxPhone.Text;
                contact.UserEmail = txtBoxEmail.Text;

                Update();
            }
            else
            { 
              Contact contact = new Contact();
              contact.UserImput(txtBoxName.Text,txtBoxStreet.Text,txtBoxZipCode.Text,txtBoxCity.Text,txtBoxPhone.Text,txtBoxEmail.Text);

              _database.SaveToFile(contact);

            ClearTextbox();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var contactId = HttpRuntime.Cache["CONTACT_ID"] as string;

            Database.DeleteContact(contactId);

                int index = _book.FindIndex(x => x.Id == contactId);
                _book.RemoveAt(index);
                listBox1.DataSource = new List<Contact>();

                ClearTextbox();
                txtBoxSearch.Focus();



        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Contact> searchResult = new List<Contact>();
            string searchText = txtBoxSearch.Text.ToLower();
            
            foreach (var contact in _book)
            {
                if (contact.UserName.Contains(searchText))
                {
                    searchResult.Add(contact);
                }
                else if (contact.UserStreet.Contains(searchText))
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

            HttpRuntime.Cache.Insert("CONTACT_ID", contact.Id);        
        }

        public void Update()
        {
            using (StreamWriter writer = new StreamWriter(pathToTextFile))
            {
                {
                foreach (var person in _book)
                    writer.WriteLine($"{person.UserName},{person.UserStreet},{person.UserZipCode},{person.UserCity},{person.UserPhoneNr},{person.UserEmail},{person.Id}");
                }
            }
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
            HttpRuntime.Cache.Remove("CONTACT_ID");
        }

        public void ValidateFields()
        {
            if (txtBoxName.Text == "" && txtBoxSearch.Text == "" && txtBoxCity.Text == "" && txtBoxPhone.Text 
                =="" && txtBoxEmail.Text == "" && txtBoxStreet.Text == "" && txtBoxZipCode.Text == "")
            {
                btnSave.Visible = false;
            }
            else
            {
                btnSave.Visible = true;
            }

            if (listBox1.SelectedItem == null)
            {
                buttonRemove.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
            }

            

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void txtBoxStreet_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void txtBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void txtBoxCity_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }
    }

}
