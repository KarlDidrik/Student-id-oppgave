using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Oppgave_Løkker
{
    internal class Karakterer
    {
        private Student Student { get; set; }
        private Fag Fag { get; set; }
        private int Karakterverdi { get; set; }
        
        public Karakterer(Student student, Fag fag, int karakterverdi)
        {
            Student = student;
            Fag = fag;
            Karakterverdi = karakterverdi;
        }

        


        public void SkrivUtInfo()
        {
            Console.WriteLine($"Studenten er {Student.Navn}, tar dette faget {Fag.Fagnavn} og har karakterverdi {Karakterverdi}");
        }
    }
}
