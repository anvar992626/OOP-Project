using System.ComponentModel.DataAnnotations;

namespace EntitetsLager
{
    public class Expedit
    {
        [Key]
        public int Anställningsnummer { get; set; }
        public string Namn { get; set; }
        public string Lösenord { get; set; }
        public string Roll { get; set; }

        public Expedit(int anställningsnummer, string namn, string lösenord, string roll)
        {
            Anställningsnummer = anställningsnummer;
            Namn = namn;
            Lösenord = lösenord;
            Roll = roll;
        }

        public Expedit(string namn, string lösenord, string roll)
        {
            Namn = namn;
            Lösenord = lösenord;
            Roll = roll;
        }
        public bool VerifieraLösenord(string lämnad)
        {
            return Lösenord == lämnad;
        }
        public Expedit() { } 

    }

}
