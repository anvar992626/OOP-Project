using System.ComponentModel.DataAnnotations;

namespace EntitetsLager
{
    public class Medlem
    {
        [Key]
        public int MedlemsNummer { get; set; }
        public string Namn { get; set; }
        public int Telefonnummer { get; set; }
        public string Epostadress { get; set; }

        public Medlem(string namn, int telnr, string epostadress)
        {
            Namn = namn;
            Telefonnummer = telnr;
            Epostadress = epostadress;
        }
        private Medlem() { } 
    }
}






