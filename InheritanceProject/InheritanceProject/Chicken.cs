using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Chicken : Animal
    {
        public Chicken(string _name, int _age)
        {
            name = _name;
            age = _age;
        }

        /// <summary>
        /// The chicken celebrates it's birthday. Returns true if the chicken survives another year, otherwise false.
        /// </summary>
        public override bool HaveBirthday()
        {
            age++;
            if (age < 8)
                return true;
            return false;
        }
    }
}
