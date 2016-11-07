using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        public bool alive = true;

        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public abstract bool HaveBirthday();

        public abstract int CalculateYearProduction();
    }
}
