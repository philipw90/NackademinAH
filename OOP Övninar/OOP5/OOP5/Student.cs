using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    public class Student
    {
        public DialogResult dialogResult;

        public Student(string firstName, string lastName, string email, string personalNumber, string mobileNumber)
        {
            Controller newController = new Controller();
            bool checkValues = newController.ControllInputValues(firstName, lastName, personalNumber, mobileNumber, email);

            if (checkValues && (dialogResult = MessageBox.Show("Alla värden är ifylda! Stämmer dem? \n" + firstName + "\n" + lastName + "\n" + email + "\n" + personalNumber + "\n" + mobileNumber, "Informationskontroll", MessageBoxButtons.YesNo))
                == DialogResult.Yes)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.email = email;
                this.mobileNumber = mobileNumber;
                this.personNumber = personalNumber;
                
            }

        }

        public string lastName { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string mobileNumber { get; set; }
        public string personNumber { get; set; }

        public string[,] GetGrades()
        {
            string[,] gradeArray = new string[,]{{"Programmering C#", "G"}, {"ASP.NET med C#", "VG"}, {"Frontend utveckling", "VG"}};
            {
                return gradeArray;
            }

        }
    }
}
