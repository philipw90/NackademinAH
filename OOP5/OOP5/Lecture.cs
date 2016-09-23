using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace OOP5
{
    class Lecture
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool Book(string staffingClassroom)
        {
            if (this.StartTime == null || this.EndTime == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool RemoveTime(string staffingClassroom)
        {
            if (this.StartTime == null || this.EndTime == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
