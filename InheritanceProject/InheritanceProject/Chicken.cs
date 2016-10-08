using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Chicken : Animal
    {
        public int eggProduction;
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
            {
                return alive = true;
            }
            else
            {
                return alive = false;
            }
            
        }

        public override int CalculateYearProduction()
        {
            Random random = new Random();
            eggProduction = random.Next(40, 100);
            return eggProduction;
        }

    }
}
