using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Oppgave_Løkker
{
    internal class Fag
    {
        private int Fagkode { get; set; }
        public string Fagnavn { get; set; }
        private int AntallStudiepoeng { get; set; }

        public Fag(int fagkode, string fagnavn, int antallStudiepoeng)
        {
            Fagkode = fagkode;
            Fagnavn = fagnavn;
            AntallStudiepoeng = antallStudiepoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"FagKoden er: {Fagkode}, fagnavn er: {Fagnavn} og antall studiepoeng er: {AntallStudiepoeng}");
        }
    }
}
