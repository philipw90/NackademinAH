using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    class Controller
    {

        public bool ControllInputValues(string firstName, string lastName, string personalNumber, string mobileNumber, string email)
        {
            List<string> valueName = new List<string>();
            valueName.Add("Förnamnet");
            valueName.Add("Efternamnet");
            valueName.Add("Mailadress");
            valueName.Add("Personnummer");
            valueName.Add("Telefonnummer");

            List<string>textName =new List<string>();
            textName.Add(firstName);
            textName.Add(lastName);
            textName.Add(email);
            textName.Add(personalNumber);
            textName.Add(mobileNumber);

            for (int i = 0; i < textName.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(textName[i]))
                {
                    MessageBox.Show(valueName[i] + " är ej i fyllt");
                    return false;
                }

            }
            return true;
        }

    }
}
