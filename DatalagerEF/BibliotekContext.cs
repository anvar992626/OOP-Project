using EntitetsLager;
using Microsoft.EntityFrameworkCore;

namespace DatalagerEF
{
    public class BibliotekContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sqlutb2.hb.se,56077;Database=osu2313;User Id=osu2313 ;Password=xy2642;");
            //optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        public BibliotekContext()
        {
            //resetSeed(); 
        }

        public DbSet<Bok> Böcker { get; set; }
        public DbSet<Bokning> Bokningar { get; set; }
        public DbSet<Expedit> Expediter { get; set; }
        public DbSet<Medlem> Medlemmar { get; set; }
        public DbSet<Faktura> Fakturor { get; set; }
        public DbSet<BokBokning> BokBokningar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BokBokning>()
                .HasKey(bb => new { bb.BokId, bb.BokningId });         // Vet ej om denna är 100% rätt

            modelBuilder.Entity<BokBokning>()
                .HasOne(bb => bb.Bok)
                .WithMany(b => b.BokBokningar)
                .HasForeignKey(bb => bb.BokId);

            modelBuilder.Entity<BokBokning>()
                .HasOne(bb => bb.Bokning)
                .WithMany(bn => bn.BokBokningar)
                .HasForeignKey(bb => bb.BokningId);
        }


        public void Reset()

        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Database.ExecuteSqlRaw("EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");
                    Database.ExecuteSqlRaw("EXEC sp_MSforeachtable 'DROP TABLE ?'");
                }
                catch (System.Exception) { }
            }
        }

        private void resetSeed()
        {
            Reset();
            Database.EnsureCreated();

            Bok bok1 = new Bok(555, "Tarzan", true);
            Böcker.Add(new Bok(111, "Sagan om Ringen", true));
            Böcker.Add(new Bok(333, "Lejonkungen", false));
            Böcker.Add(new Bok(222, "Matte 3b", true));
            Böcker.Add(new Bok(444, "Game of Thrones", true));
            Böcker.Add(new Bok(666, "House of Dragons", true));
            Böcker.Add(new Bok(777, "Italien. varför?", true));
            Böcker.Add(new Bok(999, "Tyskland, därför.", true));
            Böcker.Add(bok1);

            Expediter.Add(new Expedit("Kalle Kula", "456", "Expedit"));
            Expediter.Add(new Expedit("Fille Fjös", "123", "Expedit"));

            Medlem m1 = new Medlem("Frans Fransson", 0707658823, "Frans@live.se");
            Medlemmar.Add(new Medlem("Olle Olsson", 0702367734, "Olle99@hotmail.com"));
            Medlemmar.Add(m1);

            SaveChanges();

        }


    }

}
