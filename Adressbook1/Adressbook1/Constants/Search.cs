using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adressbook1.User;

namespace Adressbook1.Constants
{
    public class Search
    {
        List<Contact> book;
        Database database;

        public Search()
        {
            database = new Database();
            book = database.GetFile();
        }

        //public List<Contact> SearchName(string name)
        //{
        //    List<Contact> searchResult = new List<Contact>();
        //    foreach (var contact in book)
        //    {
        //        if (contact.UserName.Contains(name))
        //        {
        //            searchResult.Add(contact);
        //        }
        //        if (contact.UserStreet.Contains(name))
        //        {
        //            searchResult.Add(contact);
        //        }
        //    }
        //    return searchResult;
        //}

        //public List<Contact> SearchStreet(string name)
        //{
        //    List<Contact> searchResult = new List<Contact>();
        //    foreach (var contact in book)
        //    {
        //        if (contact.UserStreet.Contains(name))
        //        {
        //            searchResult.Add(contact);
        //        }
        //    }
        //    return searchResult;
        //}
    }
}
