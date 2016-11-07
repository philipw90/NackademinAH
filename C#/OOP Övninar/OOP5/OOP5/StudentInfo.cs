using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    public partial class StudentInfo : Form
    {

        public StudentInfo(Student newStudent)
        {
            InitializeComponent();
            lblFirstName.Text = newStudent.firstName;
            lblLastName.Text = newStudent.lastName;
            lblPerNr.Text = newStudent.personNumber;
            lblPhoneNr.Text = newStudent.mobileNumber;
            lblEmail.Text = newStudent.email;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPhoneNr_Click(object sender, EventArgs e)
        {

        }

        private void lblPerNr_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
