using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
{
    class Teachers
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        public string[] ResponsibleTeacher()
        {

            return GetCourses();
        }

        private string[] GetCourses()
        {
            string[] myArray = {"Front-end programmering", "Webb introduktion", "Programmering C#"};
            return myArray;
        }
    }

}
