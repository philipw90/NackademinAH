using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Message
    {
        public string text { get; set; }


        public string ShowMessage(string text)
        {
            return "Hello World!! " + text;
        }
    }
}
