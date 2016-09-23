using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP15
{
    class Booking
    {
        public string BookingId { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public Courses CourseId { get; set; }
        public Customer CustomerId { get; set; }


        
    }
}
