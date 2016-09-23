using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressbook1.User
{
    public class Contact
    {
        public string UserName { get; set; }

        public string UserStreet { get; set; }

        public string UserZipCode { get; set; }

        public string UserCity { get; set; }

        public string UserPhoneNr { get; set; }

        public string UserEmail { get; set; }

        public string Id { get; set; }



        public void UserImput(string name, string street, string zipcode, string city, string phonenr, string email)
        {
            UserName = name;
            UserStreet = street;
            UserZipCode = zipcode;
            UserCity = city;
            UserPhoneNr = phonenr;
            UserEmail = email;
            Id = Guid.NewGuid().ToString();

                      
        }
    }
   

    
}
