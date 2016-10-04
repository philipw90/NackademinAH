using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Database _database = new Database();
        private List<Contact> _addressbook;

        private static string pathToTextFile = @"C:\Projects\Adressbook.txt";

        public Form1()
        {
            InitializeComponent();
            _addressbook = _database.GetFile();
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

            var contact = _addressbook.First(x => x.Id == contactId);

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
                HttpRuntime.Cache.Remove("CONTACT_ID");
                Contact contact = new Contact();
                contact.UserImput(txtBoxName.Text.ToLower(), txtBoxStreet.Text.ToLower(), txtBoxZipCode.Text.ToLower(),
                txtBoxCity.Text.ToLower(), txtBoxPhone.Text.ToLower(), txtBoxEmail.Text.ToLower());

                _database.SaveToFile(contact);
                _addressbook.Add(contact);
                listBox1.DataSource = _addressbook;
                listBox1.DisplayMember = "UserName";

                ClearTextbox();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var contactId = HttpRuntime.Cache["CONTACT_ID"] as string;

            Database.DeleteContact(contactId);

            int index = _addressbook.FindIndex(x => x.Id == contactId);
            _addressbook.RemoveAt(index);
            listBox1.DataSource = new List<Contact>();

            ClearTextbox();
            txtBoxSearch.Focus();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Contact> searchResult = new List<Contact>();
            string searchText = txtBoxSearch.Text.ToLower();

            foreach (var contact in _addressbook)
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
            try
            {
                var contact = (Contact) listBox1.SelectedItem;

                txtBoxName.Text = contact.UserName;
                txtBoxStreet.Text = contact.UserStreet;
                txtBoxZipCode.Text = contact.UserZipCode;
                txtBoxCity.Text = contact.UserCity;
                txtBoxPhone.Text = contact.UserPhoneNr;
                txtBoxEmail.Text = contact.UserEmail;

                HttpRuntime.Cache.Insert("CONTACT_ID", contact.Id);
            }
            catch (Exception)
            {
            }
        }

        public void Update()
        {
            using (StreamWriter writer = new StreamWriter(pathToTextFile))
            {
                {
                    foreach (var person in _addressbook)
                        writer.WriteLine(
                            $"{person.UserName},{person.UserStreet},{person.UserZipCode},{person.UserCity},{person.UserPhoneNr},{person.UserEmail},{person.Id}");
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
                == "" && txtBoxEmail.Text == "" && txtBoxStreet.Text == "" && txtBoxZipCode.Text == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
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
            CheckFeildsToClearCache();
        }

        private void txtBoxStreet_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
            CheckFeildsToClearCache();
        }

        private void txtBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
            CheckFeildsToClearCache();
        }

        private void txtBoxCity_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
            CheckFeildsToClearCache();
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
            CheckFeildsToClearCache();
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
            CheckFeildsToClearCache();
        }    

        public void CheckFeildsToClearCache()
        {
            if (txtBoxName.Text == "" && txtBoxSearch.Text == "" && txtBoxCity.Text == "" && txtBoxPhone.Text
                == "" && txtBoxEmail.Text == "" && txtBoxStreet.Text == "" && txtBoxZipCode.Text == "")
            {
                HttpRuntime.Cache.Remove("CONTACT_ID");
            }

        }
    }


}
