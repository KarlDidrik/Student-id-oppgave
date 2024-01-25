using Moodle_Oppgave_Løkker;


var k1Fag = new Fag(1645, "Informasjons teknologi", 30);
var k1Student = new Student("Karl", 24, "IT", 38419, new List<Fag>{k1Fag});
var k1Karakterer = new Karakterer(k1Student, k1Fag, 2);

var k2Fag = new Fag(2453, "Sykepleier", 180);
var k2Student = new Student("Henning", 18, "HELSE", 29481, new List<Fag>{k2Fag});
var k2Karakterer = new Karakterer(k2Student, k2Fag, 4);
    

k1Karakterer.SkrivUtInfo();
k1Fag.SkrivUtInfo();
k1Student.SkrivUtInfo();

k2Karakterer.SkrivUtInfo();
k2Student.SkrivUtInfo();
k2Fag.SkrivUtInfo();
k1Student.Fag.Add(new Fag(23493, "Matte", 30));