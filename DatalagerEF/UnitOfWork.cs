using EntitetsLager;
using System;

namespace DatalagerEF
{
    public class UnitOfWork 
    {
        private BibliotekContext context;
        public Repository<Bok> BokRepos { get; private set; }
        public Repository<Bokning> BokningRepos { get; private set; }
        public Repository<Expedit> ExpeditRepos { get; private set; }
        public Repository<Faktura> FakturaRepos { get; private set; }
        public Repository<Medlem> MedlemRepos { get; private set; }
        //public Repository<BokBokning> BokBokningRepos { get; private set; }

        public UnitOfWork()
        {
            context = new BibliotekContext();

            BokningRepos = new Repository<Bokning>(context);
            BokRepos = new Repository<Bok>(context);
            ExpeditRepos = new Repository<Expedit>(context);
            FakturaRepos = new Repository<Faktura>(context);
            MedlemRepos = new Repository<Medlem>(context);
            //BokBokningRepos = new Repository<BokBokning> (context);

        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
