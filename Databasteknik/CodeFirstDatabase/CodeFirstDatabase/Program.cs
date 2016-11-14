using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDatabase.Models;

namespace CodeFirstDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ApplicationDbContext())
            {
                //Category category = new Category
                //{
                //    Id = 1,
                //    Name = "Work"
                //};
                //db.Categories.Add(category);
                //db.SaveChanges();

                //var contact = new Contact
                //{
                //    Id = 1,
                //    Firstname = "Göran",
                //    Lastname = "Göransson",
                //    Email = "filip@filip.se",
                //    Phone = "0704443325",
                //    Category = db.Categories.Find(1)
                //};
                //db.Contacts.Add(contact);
                //db.SaveChanges();

                var contactList = db.Contacts;

                foreach (var x in contactList)
                {
                    Console.WriteLine($"{x.Firstname}\t{x.Lastname}\t{x.Email}\t{x.Phone}\t{x.Category.Name}");
                }

            }

        }
    }
}
