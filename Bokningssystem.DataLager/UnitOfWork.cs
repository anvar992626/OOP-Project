//using EntitetsLager;

//namespace DataLager
//{
//    public class UnitOfWork
//    {
//        public Repository<Bok> BokRepos { get; private set; }
//        public Repository<Bokning> BokningRepos { get; private set; }
//        public Repository<Expedit> ExpeditRepos { get; private set; }
//        public Repository<Faktura> FakturaRepos { get; private set; }
//        public Repository<Medlem> MedlemRepos { get; private set; }


//        /// <summary>
//        ///  Create a new instance.
//        /// </summary>
//        public UnitOfWork()
//        {
//            BokningRepos = new Repository<Bokning>();
//            BokRepos = new Repository<Bok>();
//            ExpeditRepos = new Repository<Expedit>();
//            FakturaRepos = new Repository<Faktura>();
//            MedlemRepos = new Repository<Medlem>();

//            if (MedlemRepos.IsEmpty())
//            {
//                Fill();
//            }
//        }
//        /// <summary>
//        ///  Save the changes made. Does nothing in this case.
//        /// </summary>
//        public void Save()
//        { }
//        private void Fill()
//        {
//            BokRepos.Add(new Bok(11, "Sagan om grisen", true));
//            BokRepos.Add(new Bok(12, "Grabbarna grus", true));
//            BokRepos.Add(new Bok(13, "Harry Potter", true));
//            BokRepos.Add(new Bok(14, "Italien, varför?", false));
//            BokRepos.Add(new Bok(15, "Tro och kärlek", false));
//            BokRepos.Add(new Bok(16, "Träning och kost", true));
//            BokRepos.Add(new Bok(17, "Pippi Långstrump", true));
//            BokRepos.Add(new Bok(18, "Game Of Thrones", true));
//            BokRepos.Add(new Bok(19, "Matte 3b", true));
//            BokRepos.Add(new Bok(20, "Tarzan i djungeln, för vart annars ska han vara?", true));

//            ExpeditRepos.Add(new Expedit(111, "Adam", "aaa", "Expedit"));
//            ExpeditRepos.Add(new Expedit(222, "Bengt", "bbb", "Expedit"));

//            //MedlemRepos.Add(new Medlem("Sixten Skog", 0702304050, "Sixten@hotmail.com"));
//            //MedlemRepos.Add(new Medlem("Lennart Gimlisson", 0722632545, "Lenny@msn.com"));
//            //MedlemRepos.Add(new Medlem("Johan Öh", 0765126669, "Öh@icloud.com"));

//        }
//    }
//}
