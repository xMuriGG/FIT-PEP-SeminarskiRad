using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using CZE_DAL.Models;

namespace CZE_DAL
{
    public class CZEContext:DbContext
    {
        public CZEContext() : base("CZEConnectionString"){}

        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Zaposlenik> Zaposlenici { get; set; }
        public DbSet<Kandidat> Kandidati { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<BrojTelefona> BrojeviTelefona { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalozi { get; set; }
        public DbSet<KursKategorija> KursKategorije { get; set; }
        public DbSet<KursTip> KursTipovi { get; set; }
        public DbSet<Kurs> Kursevi { get; set; }
        public DbSet<Ocjene> Ocjene { get; set; }

        public DbSet<Grupa> Grupe { get; set; }
        public DbSet<GrupaKandidati> GrupeKandidati { get; set; }
        public DbSet<UplataKandidata> UplateKandidata { get; set; }
        public DbSet<Certifikat> Certifikati { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Osoba
            modelBuilder.Entity<Osoba>().HasMany(x => x.BrojTelefona).WithRequired(x => x.Osoba).WillCascadeOnDelete(true);

            modelBuilder.Entity<Osoba>().Property(t => t.Ime).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Osoba>().Property(t => t.Prezime).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Osoba>().Property(t => t.Spol).IsRequired();
            modelBuilder.Entity<Osoba>().Property(t => t.Email).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Osoba>().Property(t => t.Adresa).IsRequired().HasMaxLength(100);
            //Kandidat
            modelBuilder.Entity<Kandidat>().HasRequired(x=>x.Osoba).WithOptional(x=>x.Kandidat).WillCascadeOnDelete(true);
            //BrojTelefona
            modelBuilder.Entity<BrojTelefona>().Property(t => t.Broj).IsRequired().HasMaxLength(15);
            //Grad
            modelBuilder.Entity<Grad>().Property(t => t.Naziv).IsRequired().HasMaxLength(50);
            //modelBuilder.Entity<Grad>().Property(t => t.PTT).IsRequired().HasMaxLength(10);
            //KoricnickiNalog
            modelBuilder.Entity<KorisnickiNalog>().Property(t => t.KorisnickoIme).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<KorisnickiNalog>().Property(t => t.LozinkaHash).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<KorisnickiNalog>().Property(t => t.LozinkaSalt).IsRequired().HasMaxLength(50);
            //Zaposlenik
            modelBuilder.Entity<Zaposlenik>().HasRequired(x => x.Osoba).WithOptional(x => x.Zaposlenik).WillCascadeOnDelete(true);
            modelBuilder.Entity<Zaposlenik>().Property(t => t.StepenObrazovanja).IsRequired();
            modelBuilder.Entity<Zaposlenik>().Property(t => t.BrojRadneKnjizice).IsRequired().HasMaxLength(50);
            //Grupa
            modelBuilder.Entity<Grupa>().Property(t => t.Naziv).IsRequired().HasMaxLength(100);
            //Kurs
            modelBuilder.Entity<Kurs>().Property(t => t.Naziv).IsRequired().HasMaxLength(100);
            //KursTip
            modelBuilder.Entity<KursTip>().Property(t => t.Naziv).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<KursTip>().Property(t => t.Opis).IsRequired().HasMaxLength(1000);
            //KursKategorija
            modelBuilder.Entity<KursTip>().Property(t => t.Naziv).IsRequired().HasMaxLength(50);
            //Certifikat
            modelBuilder.Entity<Certifikat>().HasRequired(x => x.GrupaKandidati).WithOptional(x => x.Certifikat).WillCascadeOnDelete(true);

        }


    }
 
}
