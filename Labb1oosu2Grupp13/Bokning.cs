using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitetsLager
{
    public class Bokning
    {
        [Key] 
        public int Bokningsnummer { get; private set; }
        public bool Aktiv { get; private set; }
        public Medlem Medlemsnummer { get; private set; }
        public DateTime Utlämningsdatum { get; private set; }
        public DateTime Återlämningsdatum { get; private set; }

        [NotMapped]
        public List<Bok> Bok { get; private set; }
        

        public Bokning(Medlem medlemsnummer, DateTime hämtad, DateTime returnerad, List<Bok> bok, Expedit expedit, bool aktiv)
        {
            Aktiv = aktiv;
            Medlemsnummer = medlemsnummer;
            Utlämningsdatum = hämtad;
            Återlämningsdatum = returnerad;
            Bok = bok;
        }
        private Bokning() { } 
        public ICollection<BokBokning> BokBokningar { get; set; } = new List<BokBokning>();
    }
}












