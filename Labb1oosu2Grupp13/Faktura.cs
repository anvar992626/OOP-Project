using System;
using System.ComponentModel.DataAnnotations;

namespace EntitetsLager
{
    public class Faktura
    {
        [Key]
        public int Fakturanummer { get; set; }
        public int Totalpris { get; set; }
        public int Bokningsnummer { get; private set; }
        public Expedit AnställningsNummer { get; set; }  
        public DateTime FaktisktÅterlämningsdatum { get; private set; }

        public Faktura(int totalpris, int bokningsnummer, DateTime faktisktÅterlämningsdatum)
        {
            Totalpris = totalpris;
            Bokningsnummer = bokningsnummer;
            FaktisktÅterlämningsdatum = faktisktÅterlämningsdatum;
            
        }
        private Faktura() { }
    }

}