using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Oppgave_Løkker
{
    internal class Student
    {
        public string Navn { get; set; }
        private int Alder { get; set; }
        private string Studieprogram { get; set; }
        private int StudentID { get; set; }

        public List<Fag>Fag { get; set; }

        public Student(string navn, int alder, string studieprogram, int studentId, List<Fag> fag)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentId;
            Fag = fag;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navnet til studenten er {Navn}, alderen til studenten er {Alder}, studiet studenten går på er {Studieprogram} og student sin Id er {StudentID} studiene har disse fagene {getFag()}");
        }

        private string getFag()
        {
            string[]result = new string[Fag.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Fag[i];
            }
        }
    }
}
