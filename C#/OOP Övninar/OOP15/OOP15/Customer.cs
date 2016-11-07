using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP15
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilNumber { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StreetAdress { get; set; }
        public string CustomerId { get; set; }

        public string CreateCustomer()
        {
            FirstName = "Andre";
            LastName = "Holmlund";
            MobilNumber = "0722230999";
            Email = "andre.holmlund@gmail.com";
            PostalCode = "12139";
            City = "Johanneshov";
            StreetAdress = "Falköpingsvägen 17";
            CustomerId = "8903020100";
            
            return CustomerId;

        }

    }
}
