using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12.Customer
{
    class Customer
    {
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAdress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Offers { get; set; }
        public bool TipChildBooks { get; set; }
        public bool TipThrillerBooks { get; set; }
        public bool Student { get; set; }
        public bool MemberMedMera { get; set; }
        public string MedMeraCardNumber { get; set; }

        private List<string> ValidateFields()
        {
            if (MemberMedMera == true)
            {
               bool validateMedMera = ValidateMedMeraCard(MedMeraCardNumber);
            }

            return
        }
        private bool ValidateMedMeraCard(string MedMeraCardNumber)
        {
            // Kontrollera kortnummer
        }

        public bool CreateAccount()
        {
            
        }

        public bool ChangeAdress()
        {
            
        }

        public bool ChangePassword()
        {
            
        }

    }
}
