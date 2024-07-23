using DatalagerEF;
using EntitetsLager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AffärsLager
{
    public class Controller
    {
        public UnitOfWork unitOfWork = new UnitOfWork();
        public Expedit LoggedIn
        {
            get; private set;
        }

        /// <summary>
        /// Systemoperationen för att logga in.
        /// </summary>
        /// <param name="expeditNr"></param>
        /// <param name="lösenord"></param>
        /// <returns></returns>
        public bool LoggaIn(int expeditNr, string lösenord)
        {
            unitOfWork = new UnitOfWork();
            Expedit e = unitOfWork.ExpeditRepos.FirstOrDefault(e => e.Anställningsnummer == expeditNr);
            if (e != null && e.VerifieraLösenord(lösenord))
            {
                LoggedIn = e;
                return true;
            }
            LoggedIn = null;
            return false;
        }

        /// <summary>
        /// Visar en lista med de böcker som finns tillgängliga.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        public IList<Bok> VisaTillgängligaBöcker()
        {
            if (LoggedIn == null)
            {
                throw new ApplicationException("Ingen användare är inloggad just nu.");
            }
            List<Bok> tillgänglig = new List<Bok>();
            foreach (Bok b in unitOfWork.BokRepos.Find(b => b.Tillgänglig))
            {
                tillgänglig.Add(b);
            }
            return tillgänglig;
        }

        /// <summary>
        /// Sparar en bokning.
        /// </summary>
        /// <param name="bok"></param>
        /// <param name="medlemsnummer"></param>
        /// <param name="StartTid"></param>
        /// <param name="SlutTid"></param>
        /// <returns></returns>
        public Bokning SparaBokning(List<Bok> bok, int medlemsnummer, DateTime StartTid, DateTime SlutTid)
        {
            unitOfWork = new UnitOfWork();
            Medlem m = unitOfWork.MedlemRepos.FirstOrDefault(m2 => m2.MedlemsNummer == medlemsnummer);

            Bokning b = new Bokning(m, StartTid, SlutTid, bok, LoggedIn, true);
            unitOfWork.BokningRepos.Add(b);
            unitOfWork.Save();
            return b;
        }



        /// <summary>
        /// Hämtar alla böcker som markeras som tillgängliga.
        /// </summary>
        /// <returns></returns>
        public IList<Bok> HämtaTillgängligaBöcker()
        {

            IList<Bok> tillgängligaBöcker = new List<Bok>();
            foreach (Bok item in unitOfWork.BokRepos.Find(b => b.Tillgänglig))
            {
                tillgängligaBöcker.Add(item);

            }
            //IEnumerable<Bok> tillgängligaBöcker = UnitOfWorkef.BokRepos.Find(b => b.Tillgänglig);
            return tillgängligaBöcker.ToList();
        }

        public void Otillgänglig(Bok bok)
        {
            bok.Tillgänglig = false;
        }

        /// <summary>
        /// Hämtar samtliga aktiva bokningar i systemet.
        /// </summary>
        /// <returns></returns>
        public IList<Bokning> HämtaBokningar()
        {
            IEnumerable<Bokning> AllaBokningar = unitOfWork.BokningRepos.Find(b => b.Aktiv);
            return AllaBokningar.ToList();
        }

        /// <summary>
        /// Metod som används för att lämna ut en bokning till en medlem.
        /// </summary>
        /// <param name="bokningsnummer"></param>
        /// <returns></returns>
        public Bokning Utlämning(int bokningsnummer)
        {
            Bokning b = unitOfWork.BokningRepos.FirstOrDefault(b2 => b2.Bokningsnummer == bokningsnummer);

            return b;
        }

        /// <summary>
        /// Metod som används för att ta emot en bokning som en medlem lämna tillbaka.
        /// </summary>
        /// <param name="bokningsnummer"></param>
        /// <returns></returns>
        public Faktura LämnaInBokning(int bokningsnummer)
        {
            Bokning b = unitOfWork.BokningRepos.FirstOrDefault(b2 => b2.Bokningsnummer == bokningsnummer);
            foreach (var bok in b.Bok)
            {
                bok.Tillgänglig = true;
            }
            int totalpris = 0;
            DateTime återlämningsdatum = DateTime.Now;
            int antaldagar = Convert.ToInt32((återlämningsdatum - b.Återlämningsdatum).TotalDays);
            if (antaldagar > 10)
            {
                totalpris = antaldagar * 10;
            }
            Faktura f = new Faktura(totalpris, b.Bokningsnummer, DateTime.Now); 
            unitOfWork.FakturaRepos.Add(f);
            unitOfWork.Save();
            return f;
        }

       

    }

}

