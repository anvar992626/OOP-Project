using AffärsLager;
using EntitetsLager;
using System;
using System.Collections.Generic;
//using DataLager;

namespace PresentationsLager 
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program().Main();
        }

        private Program()
        {
            kontroller = new Controller();
        }

        private void Main()
        {
            Console.WriteLine("Välkommen till Expeditapplikationen!");
            while (true)
            {
                //try
                //{
                    if (LoggaIn())
                    {
                        Console.WriteLine("Ni är nu inloggad som {0} ", kontroller.LoggedIn.Namn);
                        HuvudMeny();
                    }
                    else
                    {
                        Console.WriteLine("Inloggning misslyckades. Försök igen: " + "\n");
                    }
            }
            //    catch (Exception e)
            //{
            //    Console.WriteLine("SYSTEMFEL: " + e.Message);
        //    //}
        //}
        }

        private bool LoggaIn()
        {
            string anställningsIdToParse = "";
            int anställnigsId;
            while (!int.TryParse(anställningsIdToParse, out anställnigsId))
            {
                Console.WriteLine("Vänligen ange ert anställningsnummer: ");
                anställningsIdToParse = Console.ReadLine();
            }
            Console.WriteLine("Vänligen ange ert lösenord: ");
            string lösenord = Console.ReadLine();
            //Expedit expedit = kontroller.LoggaIn(anställnigsId, lösenord);
            return kontroller.LoggaIn(anställnigsId, lösenord);
        }

        /// <summary>
        /// Huvudmenyn för själva applikationen.
        /// </summary>
        private void HuvudMeny()
        {
            Console.WriteLine("=== Bokningsystem - Huvudmeny===");
            Console.WriteLine("| Välj ett Menyalternativ      |");           
            Console.WriteLine("| 1. Skapa en bokning          |");   
            Console.WriteLine("| 2. Utlämning av bokning      |");
            Console.WriteLine("| 3. Återlämning av bokning    |");  
            Console.WriteLine("| 4. Avsluta                   |");
            Console.WriteLine("================================");

            int val;
            int.TryParse(Console.ReadLine(), out val);
            switch (val)

            {
                case 1: // Menyval för att skapa en ny bokning
                    SkapaBokning();
                    HuvudMeny();
                    break;
                case 2: // Menyval för att lämna ut en redan skapad bokning till en medlem.
                    UtlämnaBokning();
                    HuvudMeny();
                    break;
                case 3: // Menyval för att ta tillbaka en bokning från en medlem.
                    ÅterlämnaBokning();
                    HuvudMeny();
                    break; // Menyval för att avsluta programmet.
                case 4:
                    AvslutaMeny();
                    break;
                default: // Ger ett felmeddelande om användaren skriver något annat än de givna menyvalen.
                    Console.WriteLine("\nEj giltigt, vänligen ange ett alternativ mellan 1-3.");
                    Console.WriteLine("\nKlicka på valfri tangent för att återgå till huvudmenyn.");
                    Console.ReadKey();
                    Console.Clear();
                    HuvudMeny();
                    break;
            }
        }

        /// <summary>
        /// Metod för att samla in informationen som skall lagras i samband med en ny bokning.
        /// </summary>
        private void SkapaBokning()
        {
            List<Bok> lånadeböcker = new List<Bok>();
            bool Val = true;
            Console.WriteLine("Vänligen ange medlemmens medlemsnummer: ");
            int Medlemsnummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bokning från: MM/DD/YYYY");
            DateTime StartTid = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ange antal dagar för bokningen:  ");
            int antalDagar = Convert.ToInt32(Console.ReadLine());
            DateTime SlutTid = StartTid.AddDays(antalDagar);
            
            Console.Clear();

            while (Val == true)
            {
                Console.Clear();

                IList<Bok> TillgängligaBöcker = kontroller.VisaTillgängligaBöcker();
                int i = 1;
                Console.WriteLine("Lista av tillgänliga böcker \n ________________________ \n");
                foreach (Bok b in TillgängligaBöcker)
                {
                    Console.WriteLine("{0}. {1}", i, b.Boktitel);
                    i++;
                }
                string noToParse = "";
                int no;
                while (!int.TryParse(noToParse, out no))
                {
                    Console.WriteLine("Ange numret för boken/böckerna som skall adderas till bokningen, ange siffran 0 för att avsluta väljandeprocessen:  ");
                    noToParse = Console.ReadLine();
                }

                if (0 < no && no <= TillgängligaBöcker.Count)
                {
                    kontroller.Otillgänglig(TillgängligaBöcker[no - 1]);
                    lånadeböcker.Add(TillgängligaBöcker[no - 1]);
                }
                else
                {
                    Val = false;
                }
            }
            Bokning bokning = kontroller.SparaBokning(lånadeböcker, Medlemsnummer, StartTid, SlutTid);
            Console.Clear();
            Console.WriteLine("Översikt av bokning \n __________________________ \n");
            Console.WriteLine("Bokningsnummmer: {0}", bokning.Bokningsnummer);
            //Console.WriteLine("Förväntat uthämtningsdatum: {0}", bokning.FörväntadUthämtningstid.ToString());
            Console.WriteLine("Faktiskt uthämtningsdatum: {0}", bokning.Utlämningsdatum.ToString());
            Console.WriteLine("Förväntat inlämningsdatum: {0}", bokning.Återlämningsdatum.ToString());
            //Console.WriteLine("Expedit: {0}", bokning.Expedit.Namn);
            Console.WriteLine("Medlem: {0}", bokning.Medlemsnummer.Namn);
            Console.WriteLine("\nLista av reserverade böcker \n________________________\n");  

            int p = 1;
            foreach (var bok in bokning.Bok)
            {
                Console.WriteLine("{0}. {1}", p, bok.Boktitel);
                p++;
            }

            Console.WriteLine("\n");
            Console.WriteLine("Klicka på valfri tangent för att återgå till huvudmenyn.");
            Console.ReadKey();
            Console.Clear();

        }

        /// <summary>
        /// Metod för att lämna ut en bokning till en medlem.
        /// </summary>
        private void UtlämnaBokning()
        {
            Console.WriteLine("Vänligen ange bokningsnumret: ");
            int bokningsnummer = Convert.ToInt32(Console.ReadLine());
            Bokning b = kontroller.Utlämning(bokningsnummer);
            if (bokningsnummer==b.Bokningsnummer)
            {

                IList<Bokning> bokningar = kontroller.HämtaBokningar();
                int i = 1;
                Console.Clear();
                Console.WriteLine("Aktiva bokningar \n ______________________\n");
                foreach (Bokning bokning in bokningar)
                {

                    Console.WriteLine("Bokningsnummmer: {0}", bokning.Bokningsnummer);
                   // Console.WriteLine("Förväntat uthämtningsdatum: {0}", bokning.FörväntadUthämtningstid.ToString());
                    Console.WriteLine("Faktiskt uthämtningsdatum: {0}", bokning.Utlämningsdatum.ToString());
                    Console.WriteLine("Förväntat inlämningsdatum: {0}", bokning.Återlämningsdatum.ToString());
                   // Console.WriteLine("Expedit: {0}", bokning.Expedit.Namn); 
                    Console.WriteLine("Medlem: {0}", bokning.Medlemsnummer.Namn);
                    
                    i++;
                    int p = 1;
                    foreach (var item in bokning.Bok)
                    {

                        Console.WriteLine("-" + item.Boktitel);
                        p++;
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("Klicka på valfri tangent för att återgå till huvudmenyn.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }

        }

        /// <summary>
        /// Metod för att Återlämna en bokning.
        /// </summary>
        void ÅterlämnaBokning()
        {

            IList<Bokning> bokningar = kontroller.HämtaBokningar();
            int i = 1;
            Console.Clear();
            Console.WriteLine("Aktiva bokningar \n ______________________\n");
            foreach (Bokning bokning in bokningar)
            {

                Console.WriteLine("{0}", bokning.Medlemsnummer.Namn);
                Console.WriteLine("Bokningsnummer: {0}\n", bokning.Bokningsnummer);
                i++;
                int p = 1;
                foreach (var item in bokning.Bok)
                {

                    Console.WriteLine("-" + item.Boktitel);
                    p++;
                }
                Console.WriteLine("\n");

            }

            Console.WriteLine("\nAnge bokningsnummer som ska returneras: ");
            int bokningsnummer = Convert.ToInt32(Console.ReadLine());
            Faktura f = kontroller.LämnaInBokning(bokningsnummer);
            Console.Clear();
            Console.WriteLine("Faktura: \n_________________\n");
            Console.WriteLine("Fakturanummer: {0}", f.Fakturanummer);
            Console.WriteLine("Pris: {0}", f.Totalpris.ToString());
            Console.WriteLine("Återlämningsdatum: {0}", f.FaktisktÅterlämningsdatum.ToString());
            Console.WriteLine("Bokningsnummer: {0}", f.Bokningsnummer);

            Console.WriteLine("\n");
            Console.WriteLine("Klicka på valfri tangent för att återgå till huvudmenyn.");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Metod för att avsluta programmet.
        /// </summary>
        private static void AvslutaMeny()        {
            Environment.Exit(0);
        }

        private Controller kontroller; 

    }
}
