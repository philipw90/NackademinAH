using System.Collections.Generic;
using System.IO;
using System.Text;
using Adressbook1.User;

namespace Adressbook1.Constants
{
   public class Database
   {
        string path = @"C:\Projects\Adressbook.txt";

        public void SaveToFile(Contact contact)
       {
            
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(contact.UserName.ToLower() +",");
            stringBuilder.Append(contact.UserStreet.ToLower() + ",");
            stringBuilder.Append(contact.UserZipCode.ToLower() + ",");
            stringBuilder.Append(contact.UserCity.ToLower() + ",");
            stringBuilder.Append(contact.UserPhoneNr.ToLower() + ",");
            stringBuilder.Append(contact.UserEmail.ToLower() + ",");
            stringBuilder.Append(contact.Id.ToLower() + ",");

           using (StreamWriter sw = new StreamWriter(path, true))
           {
               sw.WriteLine(stringBuilder);
           }
       }

        public List<Contact> GetFile()
        {

            using (var streamReader = new StreamReader(path))
            {
                var contacts = new List<Contact>();

                while (!streamReader.EndOfStream)
                {
                    var readLine = streamReader.ReadLine();

                    if (readLine != null)
                    {
                        string[] values = readLine.Split(',');
                        Contact contact = new Contact
                        {
                            UserName = values[0],
                            UserStreet = values[1],
                            UserZipCode = values[2],
                            UserCity = values[3],
                            UserPhoneNr = values[4],
                            UserEmail = values[5],
                            Id = values[6]
                        };


                        contacts.Add(contact);
                    }
                }

                return contacts;
            }
        }
    }
}