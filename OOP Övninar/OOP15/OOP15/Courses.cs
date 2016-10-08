using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP15
{
    class Courses
    {
        public string CourseId { get; set; }
        public string CourseTyp { get; set; }

        public void CreateCourses(string id, string type)
        {
            CourseTyp = type;
            CourseId = id;
        }

    }
}
