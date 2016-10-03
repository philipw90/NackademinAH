using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Adressbook1.User;

namespace Adressbook1.Constants
{
   public class Database
   {
        static string pathToTextFile = @"C:\Projects\Adressbook.txt";

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

           using (StreamWriter sw = new StreamWriter(pathToTextFile, true))
           {
               sw.WriteLine(stringBuilder);
           }
       }

        public List<Contact> GetFile()
        {
            using (var streamReader = new StreamReader(pathToTextFile))
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

        public static void DeleteContact(string contactId)
        {
            var lines = File.ReadAllLines(pathToTextFile);
            var line = 0;

            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(contactId))
                {
                    line = i;
                }
            }

            RemoveLine(pathToTextFile, line);
        }

       public static void RemoveLine(string fileName, int lineToRemove)
       {
           var arrLine = File.ReadAllLines(fileName).ToList();
            arrLine.RemoveAt(lineToRemove);

            File.WriteAllLines(fileName, arrLine);
       }
    }
}