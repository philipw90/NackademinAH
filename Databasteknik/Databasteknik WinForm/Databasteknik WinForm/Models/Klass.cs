using System.Xml;

namespace Databasteknik_WinForm.Models
{
    public class Klass
    {
        public string Kod { get; set; }
        public string Namn { get; set; }
        public int Årskurs { get; set; }

        public override string ToString()
        {
            return Namn + " (" + Årskurs + ")";
        }

    }
}
