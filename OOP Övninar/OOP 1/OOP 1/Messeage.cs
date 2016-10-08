using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Messeage
    {
        private string text;

        public string Text { get; set; }

        public string ShowMessage()
        {
            return "Hello World" + text;
        }

    }

}
