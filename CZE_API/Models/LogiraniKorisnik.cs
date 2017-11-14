using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZE_API.Models
{
   public class LogiraniKorisnik
    {
        public int KorisnickiNalogID { get; set; }
        public Osoba Osoba { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Aktivan { get; set; }
        public UlogaKorisnika UlogaKorisnika { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Spol Spol { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }

        public bool IsKandidat { get; set; }
        public bool IsZaposlenik { get; set; }
    }
}
