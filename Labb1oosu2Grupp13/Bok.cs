using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitetsLager
{
    public class Bok
    {
        
       
        public int BokId { get; set; }
        public int ISPN { get; private set; }
        public string Boktitel { get; private set; }
        public bool Tillgänglig { get; set; }

        public Bok(int ispn, string boktitel, bool tillgänglig)
        {
            ISPN = ispn;
            Boktitel = boktitel;
            Tillgänglig = tillgänglig;
        }
        private Bok()
        {
        }
        public ICollection<BokBokning> BokBokningar { get; set; } = new List<BokBokning>();

    }
}