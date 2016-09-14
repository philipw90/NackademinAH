using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Course
    {
        
        public string name { get; set; }
        public int points { get; set; }
        public DateTime endDate { get; set; }
        public DateTime startDate { get; set; }

        public double CalculateCourseLength()
        {
            return Convert.ToInt32((endDate - startDate).TotalDays +1);

        }

        public double PointsPerCourseDay()
        {
            double days = Convert.ToInt32(CalculateCourseLength());
            
            return points / days;
        }
    }
}
